-- Criação do banco de dados
DROP SCHEMA IF EXISTS TecEventos;

CREATE DATABASE IF NOT EXISTS TecEventos;

USE TecEventos;

# 1 enderecos
CREATE TABLE enderecos (
    id INT NOT NULL AUTO_INCREMENT,
    rua VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    bairro VARCHAR(50) NOT NULL,
    PRIMARY KEY (id)
);


# 2 usuários
CREATE TABLE usuarios (
    id INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    telefone VARCHAR(20),
    endereco_id INT(11),
    PRIMARY KEY (id),
    FOREIGN KEY (endereco_id) REFERENCES enderecos(id)
);

# 3 regras 
CREATE TABLE regras (
    id INT NOT NULL AUTO_INCREMENT,
    descricao TEXT NOT NULL,
    PRIMARY KEY (id)
);


# 4 politicas
CREATE TABLE politicas (
    id INT NOT NULL AUTO_INCREMENT,
    descricao TEXT NOT NULL,
    PRIMARY KEY (id)
);

# 5 chacaras
CREATE TABLE chacara (
    id INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    endereco_id INT(11),
    regras_id INT(11),
    politicas_id INT(11),
    PRIMARY KEY (id),
    FOREIGN KEY (endereco_id) REFERENCES enderecos(id),
    FOREIGN KEY (regras_id) REFERENCES regras(id),
    FOREIGN KEY (politicas_id) REFERENCES politicas(id)
);

# 6 valores_diarias
CREATE TABLE valores_diarias (
    id INT NOT NULL AUTO_INCREMENT,
    valor DECIMAL(10, 2) NOT NULL,
    dia_semana VARCHAR(10) NOT NULL,
    PRIMARY KEY (id)
);

# 7 chacaras_valores_diarias
CREATE TABLE chacaras_valores_diarias (
    id INT NOT NULL AUTO_INCREMENT,
    chacara_id INT(11),
    valor_diaria_id INT(11),
    FOREIGN KEY (chacara_id) REFERENCES chacara(id),
    FOREIGN KEY (valor_diaria_id) REFERENCES valores_diarias(id),
    PRIMARY KEY (id),
    UNIQUE INDEX idx_chacaras_valores_diarias (chacara_id, valor_diaria_id)
);

# 8 datas_comemorativas
CREATE TABLE datas_comemorativas (
    id INT NOT NULL AUTO_INCREMENT,
    descricao VARCHAR(100),
    valor_promocional_id INT(11),
    data_comemorativa DATE NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (valor_promocional_id) REFERENCES valores_diarias(id)
);

# 9 logins
CREATE TABLE logins (
    id INT NOT NULL AUTO_INCREMENT,
    usuario_id INTEGER REFERENCES usuarios(id),
    senha VARCHAR(255) NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (usuario_id) REFERENCES usuarios(id)
);

# 10 agendamentos
CREATE TABLE agendamento (
    id INT NOT NULL AUTO_INCREMENT,
    entrada_data DATE NOT NULL,
    saida_data DATE NOT NULL,
    usuario_id INT(11),
    chacara_id INT(11),
    valor_agendamento DECIMAL(10, 2) NOT NULL,
    status ENUM('Confirmada', 'Pendente', 'Cancelada'),
    PRIMARY KEY (id),
    FOREIGN KEY (usuario_id) REFERENCES usuarios(id),
    FOREIGN KEY (chacara_id) REFERENCES chacara(id),
    UNIQUE INDEX idx_agendamento (chacara_id, entrada_data)
);

# 11 controle_pagamentos
CREATE TABLE controle_pagamentos (
    id INT NOT NULL AUTO_INCREMENT,
    usuario_id INT(11),
    chacara_id INT(11),
    agendamento_id INT(11),
    valor_pago DECIMAL(10, 2) NOT NULL,
    data_pagamento DATE NOT NULL,
    metodo_pagamento ENUM('PIX', 'Depósito Bancário', 'Cartão Débito', 'Cartão Crédito'),
    status_pagamento ENUM('Pago', 'Pendente', 'Cancelado'),
    PRIMARY KEY (id),
    FOREIGN KEY (usuario_id) REFERENCES usuarios(id),
    FOREIGN KEY (chacara_id) REFERENCES chacara(id),
    FOREIGN KEY (agendamento_id) REFERENCES agendamento(id)
);

# 12 disponibilidade
CREATE TABLE disponibilidade (
    id INT NOT NULL AUTO_INCREMENT,
    chacara_id INT(11),
    data DATE NOT NULL,
    disponivel BOOLEAN NOT NULL DEFAULT TRUE,
    PRIMARY KEY (id),
    FOREIGN KEY (chacara_id) REFERENCES chacara(id),
    UNIQUE INDEX idx_disponibilidade (chacara_id, data)
);



# 13 contratos
CREATE TABLE contratos (
    id INT NOT NULL AUTO_INCREMENT,
    agendamento_id INT(11),
    data_criacao DATE NOT NULL,
    detalhes TEXT NOT NULL,
    assinatura_cliente BOOLEAN NOT NULL DEFAULT FALSE,
    assinatura_proprietario BOOLEAN NOT NULL DEFAULT FALSE,
    PRIMARY KEY (id),
    FOREIGN KEY (agendamento_id) REFERENCES agendamento(id)
);

#Inserindo Endereços
INSERT INTO enderecos (rua, numero, bairro) VALUES ('Rua das Flores', '123', 'Jardim Primavera');
INSERT INTO enderecos (rua, numero, bairro) VALUES ('Avenida Central', '456', 'Centro');
INSERT INTO enderecos (rua, numero, bairro) VALUES ('Rua do Sol', '789', 'Bela Vista');

#Inserindo Regras
INSERT INTO regras (descricao) VALUES ('Piscina disponível apenas até às 20h');
INSERT INTO regras (descricao) VALUES ('Proibido som alto após as 22h');

#Inserindo Políticas
INSERT INTO politicas (descricao) VALUES ('Check-in a partir das 14h e check-out até às 12h');
INSERT INTO politicas (descricao) VALUES ('Animais de estimação são permitidos mediante aviso prévio');

#Inserindo Chácaras
INSERT INTO chacara (nome, endereco_id, regras_id, politicas_id) VALUES 
('Chácara Vista Alegre', 
    (SELECT id FROM enderecos WHERE rua = 'Rua das Flores' AND numero = '123'),
    (SELECT id FROM regras WHERE descricao = 'Proibido som alto após as 22h'),
    (SELECT id FROM politicas WHERE descricao = 'Check-in a partir das 14h e check-out até às 12h')
);
INSERT INTO chacara (nome, endereco_id, regras_id, politicas_id) VALUES ('Chácara Paraíso', 
    (SELECT id FROM enderecos WHERE rua = 'Avenida Central' AND numero = '456'),
    (SELECT id FROM regras WHERE descricao = 'Piscina disponível apenas até às 20h'),
    (SELECT id FROM politicas WHERE descricao = 'Animais de estimação são permitidos mediante aviso prévio')
);

#Inserindo Valores de Diárias
INSERT INTO valores_diarias (valor, dia_semana) VALUES (500.00, 'Segunda-feira');
INSERT INTO valores_diarias (valor, dia_semana) VALUES (600.00, 'Sábado');
INSERT INTO valores_diarias (valor, dia_semana) VALUES (700.00, 'Domingo');

#Inserindo Valores de Diárias para Chácaras
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id) VALUES ((SELECT id FROM chacara WHERE nome = 'Chácara Vista Alegre'), 
    (SELECT id FROM valores_diarias WHERE valor = 500.00 AND dia_semana = 'Segunda-feira'));
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id) VALUES ((SELECT id FROM chacara WHERE nome = 'Chácara Vista Alegre'), 
    (SELECT id FROM valores_diarias WHERE valor = 600.00 AND dia_semana = 'Sábado'));
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id) VALUES ((SELECT id FROM chacara WHERE nome = 'Chácara Paraíso'), 
    (SELECT id FROM valores_diarias WHERE valor = 700.00 AND dia_semana = 'Domingo'));

#Inserindo Datas Comemorativas
INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) VALUES ('Natal', 
    (SELECT id FROM valores_diarias WHERE valor = 700.00 AND dia_semana = 'Domingo'), '2024-12-25');
INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) VALUES  ('Ano Novo', 
    (SELECT id FROM valores_diarias WHERE valor = 600.00 AND dia_semana = 'Sábado'), '2024-12-31');

#Inserindo Logins
INSERT INTO logins (usuario_id, senha) VALUES ((SELECT id FROM usuarios WHERE email = 'joao@gmail.com'), 'senha123');
INSERT INTO logins (usuario_id, senha) VALUES ((SELECT id FROM usuarios WHERE email = 'maria@gmail.com'), 'senha456');

#Inserindo Usuários
INSERT INTO usuarios (nome, email, telefone, endereco_id) VALUES 
('João da Silva', 'joao@gmail.com', '11999999999', 
    (SELECT id FROM enderecos WHERE rua = 'Rua das Flores' AND numero = '123'));
INSERT INTO usuarios (nome, email, telefone, endereco_id) VALUES ('Maria Oliveira', 'maria@gmail.com', '11988888888', 
    (SELECT id FROM enderecos WHERE rua = 'Avenida Central' AND numero = '456'));

#Inserindo Agendamentos
INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status) VALUES 
('2024-12-24', '2024-12-26', 
    (SELECT id FROM usuarios WHERE email = 'joao@gmail.com'),
    (SELECT id FROM chacara WHERE nome = 'Chácara Vista Alegre'),
    1200.00, 'Confirmada');
INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status) VALUES ('2024-12-31', '2025-01-02', 
    (SELECT id FROM usuarios WHERE email = 'maria@gmail.com'),
    (SELECT id FROM chacara WHERE nome = 'Chácara Paraíso'),
    1400.00, 'Pendente');

#Inserindo Controle de Pagamentos
INSERT INTO controle_pagamentos (usuario_id, chacara_id, agendamento_id, valor_pago, data_pagamento, metodo_pagamento, status_pagamento) VALUES 
((SELECT id FROM usuarios WHERE email = 'joao@gmail.com'), 
    (SELECT id FROM chacara WHERE nome = 'Chácara Vista Alegre'), 
    (SELECT id FROM agendamento WHERE entrada_data = '2024-12-24' AND usuario_id = (SELECT id FROM usuarios WHERE email = 'joao@gmail.com')), 
    1200.00, '2024-12-01', 'PIX', 'Pago');
INSERT INTO controle_pagamentos (usuario_id, chacara_id, agendamento_id, valor_pago, data_pagamento, metodo_pagamento, status_pagamento) VALUES ((SELECT id FROM usuarios WHERE email = 'maria@gmail.com'), 
    (SELECT id FROM chacara WHERE nome = 'Chácara Paraíso'), 
    (SELECT id FROM agendamento WHERE entrada_data = '2024-12-31' AND usuario_id = (SELECT id FROM usuarios WHERE email = 'maria@gmail.com')), 
    700.00, '2024-12-15', 'Cartão Crédito', 'Pendente');

#Inserindo Disponibilidade
INSERT INTO disponibilidade (chacara_id, data, disponivel) VALUES ((SELECT id FROM chacara WHERE nome = 'Chácara Vista Alegre'), '2024-12-24', FALSE);
INSERT INTO disponibilidade (chacara_id, data, disponivel) VALUES ((SELECT id FROM chacara WHERE nome = 'Chácara Paraíso'), '2024-12-31', FALSE);
INSERT INTO disponibilidade (chacara_id, data, disponivel) VALUES ((SELECT id FROM chacara WHERE nome = 'Chácara Vista Alegre'), '2024-12-28', TRUE);

#Inserindo Contratos
INSERT INTO contratos (agendamento_id, data_criacao, detalhes, assinatura_cliente, assinatura_proprietario) VALUES ((SELECT id FROM agendamento WHERE entrada_data = '2024-12-24' AND usuario_id = (SELECT id FROM usuarios WHERE email = 'joao@gmail.com')), 
    '2024-11-20', 'Contrato para a festa de Natal', TRUE, FALSE);
INSERT INTO contratos (agendamento_id, data_criacao, detalhes, assinatura_cliente, assinatura_proprietario) VALUES ((SELECT id FROM agendamento WHERE entrada_data = '2024-12-31' AND usuario_id = (SELECT id FROM usuarios WHERE email = 'maria@gmail.com')), 
    '2024-11-25', 'Contrato para a festa de Ano Novo', FALSE, FALSE);

