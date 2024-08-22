-- Criação do banco de dados
CREATE DATABASE IF NOT EXISTS TecEventos;
USE TecEventos;

CREATE TABLE Usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome_completo VARCHAR(100),
    email VARCHAR(100) UNIQUE,
    endereco_rua VARCHAR(255),
    endereco_numero VARCHAR(50),
    endereco_bairro VARCHAR(100),
    telefone VARCHAR(20),
    senha VARCHAR(255)
);

CREATE TABLE Chacara (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
    valor_diaria DECIMAL(10,2),
    endereco_rua VARCHAR(255),
    endereco_numero VARCHAR(50),
    endereco_bairro VARCHAR(100),
    regras_politicas TEXT,
    descricao TEXT
);

CREATE TABLE Agendamento (
    id INT AUTO_INCREMENT PRIMARY KEY,
    entrada_data DATE,
    saida_data DATE,
    nome_cliente VARCHAR(100),
    telefone_cliente VARCHAR(20),
    status ENUM('Confirmada', 'Pendente', 'Cancelada'),
    valor_total DECIMAL(10,2),
    chacara_id INT,
    usuario_id INT,
    FOREIGN KEY (chacara_id) REFERENCES Chacara(id),
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id)
);

CREATE TABLE ControlePagamentos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome_cliente VARCHAR(100),
    chacara_id INT,
    valor_aluguel DECIMAL(10,2),
    valor_pago DECIMAL(10,2),
    data_pagamento DATE,
    metodo_pagamento ENUM('PIX', 'Depósito Bancário', 'Cartão Débito', 'Cartão Crédito'),
    status_pagamento ENUM('Pago', 'Pendente', 'Cancelado'),
    FOREIGN KEY (chacara_id) REFERENCES Chacara(id)
);

CREATE TABLE DatasComemorativas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome_data VARCHAR(100),
    dia INT,
    mes INT,
    ano INT,
    descricao TEXT,
    promocoes TEXT,
    pacotes TEXT
);

CREATE TABLE Disponibilidade (
    id INT AUTO_INCREMENT PRIMARY KEY,
    chacara_id INT,
    data_disponibilidade DATE,
    disponivel BOOLEAN,
    FOREIGN KEY (chacara_id) REFERENCES Chacara(id)
);

CREATE TABLE Feedback (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome_cliente VARCHAR(100),
    data_feedback DATE,
    comentario TEXT,
    avaliacao INT
);

CREATE TABLE EnderecoChacara (
    id INT AUTO_INCREMENT PRIMARY KEY,
    chacara_id INT,
    endereco_rua VARCHAR(255),
    endereco_numero VARCHAR(50),
    endereco_bairro VARCHAR(100),
    cidade VARCHAR(100),
    estado VARCHAR(100),
    cep VARCHAR(10),
    FOREIGN KEY (chacara_id) REFERENCES Chacara(id)
);

CREATE TABLE ReservaChacara (
    id INT AUTO_INCREMENT PRIMARY KEY,
    agendamento_id INT,
    chacara_id INT,
    data_reserva DATE,
    hora_reserva TIME,
    status ENUM('Confirmada', 'Pendente', 'Cancelada'),
    FOREIGN KEY (agendamento_id) REFERENCES Agendamento(id),
    FOREIGN KEY (chacara_id) REFERENCES Chacara(id)
);

CREATE TABLE HistoricoPagamentos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    controle_pagamentos_id INT,
    data_historico DATE,
    descricao TEXT,
    FOREIGN KEY (controle_pagamentos_id) REFERENCES ControlePagamentos(id)
);

CREATE TABLE RegrasPoliticas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    chacara_id INT,
    descricao TEXT,
    data_atualizacao DATE,
    FOREIGN KEY (chacara_id) REFERENCES Chacara(id)
);

CREATE TABLE Promocoes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    data_comemorativa_id INT,
    descricao TEXT,
    valor_desconto DECIMAL(10,2),
    FOREIGN KEY (data_comemorativa_id) REFERENCES DatasComemorativas(id)
);

CREATE TABLE Pacotes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    data_comemorativa_id INT,
    descricao TEXT,
    valor_pacote DECIMAL(10,2),
    FOREIGN KEY (data_comemorativa_id) REFERENCES DatasComemorativas(id)
);

CREATE TABLE ClienteContato (
    id INT AUTO_INCREMENT PRIMARY KEY,
    cliente_id INT,
    tipo_contato ENUM('Telefone', 'Email', 'Outros'),
    descricao TEXT,
    FOREIGN KEY (cliente_id) REFERENCES Usuario(id)
);

CREATE TABLE LogAcesso (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario_id INT,
    data_acesso DATE,
    hora_acesso TIME,
    acao TEXT,
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id)
);


-- Inserir administrador padrão na tabela de usuários
INSERT INTO Usuario (nome_completo, email, endereco_rua, endereco_numero, endereco_bairro, telefone, senha)
VALUES ('Administrador', 'admin@teceventos.com', 'Rua Central', '1', 'Centro', '000000000', 'admin');
select * from Usuario

