-- Criação do banco de dados
CREATE DATABASE IF NOT EXISTS TecEventos;
USE TecEventos;

-- Tabela de Usuários
CREATE TABLE Usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome_completo VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    telefone VARCHAR(15) NOT NULL,
    rua VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    bairro VARCHAR(50) NOT NULL,
    senha VARCHAR(255) NOT NULL
);

-- Tabela de Chácaras
CREATE TABLE Chacara (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome_chacara VARCHAR(100) NOT NULL,
    valor_diaria DECIMAL(10, 2) NOT NULL,
    rua VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    bairro VARCHAR(50) NOT NULL,
    regras_politicas TEXT,
    descricao_detalhada TEXT
);

-- Tabela de Agendamentos
CREATE TABLE Agendamento (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_chacara INT NOT NULL,
    nome_cliente VARCHAR(100) NOT NULL,
    telefone_cliente VARCHAR(15) NOT NULL,
    data_entrada DATE NOT NULL,
    data_saida DATE NOT NULL,
    status ENUM('Confirmada', 'Pendente', 'Cancelada') NOT NULL DEFAULT 'Pendente',
    valor_total DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (id_chacara) REFERENCES Chacara(id)
);

-- Tabela de Controle de Pagamentos
CREATE TABLE ControlePagamento (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome_cliente VARCHAR(100) NOT NULL,
    nome_chacara VARCHAR(100) NOT NULL,
    valor_aluguel DECIMAL(10, 2) NOT NULL,
    valor_pago DECIMAL(10, 2),
    data_pagamento DATE,
    metodo_pagamento ENUM('PIX', 'Depósito Bancário', 'Cartão Débito', 'Cartão Crédito') NOT NULL,
    status_pagamento ENUM('Pago', 'Pendente') NOT NULL DEFAULT 'Pendente'
);

-- Tabela de Datas Comemorativas
CREATE TABLE DataComemorativa (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome_data VARCHAR(100) NOT NULL,
    dia INT NOT NULL,
    mes INT NOT NULL,
    ano INT NOT NULL,
    descricao TEXT,
    promocoes TEXT,
    pacotes TEXT
);

-- Tabela de Disponibilidades de Chácaras
CREATE TABLE DisponibilidadeChacara (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_chacara INT NOT NULL,
    data_disponivel DATE NOT NULL,
    FOREIGN KEY (id_chacara) REFERENCES Chacara(id)
);

-- Inserir administrador padrão na tabela de usuários
INSERT INTO Usuario (nome_completo, email, telefone, rua, numero, bairro, senha)
VALUES ('Administrador', 'admin@teceventos.com', '000000000', 'Rua Central', '1', 'Centro', 'admin');
