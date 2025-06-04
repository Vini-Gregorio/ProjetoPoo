-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 04/06/2025 às 15:41
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `prisionadm`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `cela`
--

CREATE TABLE `cela` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(50) DEFAULT NULL,
  `Capacidade` int(11) DEFAULT NULL,
  `OcupacaoAtual` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cela`
--

INSERT INTO `cela` (`Id`, `Nome`, `Capacidade`, `OcupacaoAtual`) VALUES
(1, 'Cela 01 ', 40, 2);

-- --------------------------------------------------------

--
-- Estrutura para tabela `detento`
--

CREATE TABLE `detento` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `DataNascimento` date DEFAULT NULL,
  `DataEntrada` date DEFAULT NULL,
  `DataSaidaPrevista` date DEFAULT NULL,
  `CelaId` int(11) DEFAULT NULL,
  `PenaId` int(11) DEFAULT NULL,
  `EstadoEmocionalId` int(11) DEFAULT NULL,
  `RegimeTipo` enum('Aberto','SemiAberto','Fechado') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `estadoemocional`
--

CREATE TABLE `estadoemocional` (
  `Id` int(11) NOT NULL,
  `Observacao` text DEFAULT NULL,
  `NivelDeRisco` enum('Baixo','Medio','Alto') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `pena`
--

CREATE TABLE `pena` (
  `Id` int(11) NOT NULL,
  `Descricao` text DEFAULT NULL,
  `DuracaoMeses` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `pergunta`
--

CREATE TABLE `pergunta` (
  `Id` int(11) NOT NULL,
  `Texto` text DEFAULT NULL,
  `Avaliador` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `respostapergunta`
--

CREATE TABLE `respostapergunta` (
  `Id` int(11) NOT NULL,
  `DetentoId` int(11) DEFAULT NULL,
  `PerguntaId` int(11) DEFAULT NULL,
  `Resposta` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuario`
--

CREATE TABLE `usuario` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `DataNascimento` date DEFAULT NULL,
  `Cargo` varchar(100) DEFAULT NULL,
  `Senha` varchar(255) DEFAULT NULL,
  `perigo` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `usuario`
--

INSERT INTO `usuario` (`Id`, `Nome`, `DataNascimento`, `Cargo`, `Senha`, `perigo`) VALUES
(1, 'Douglas', '1996-05-09', 'Delegado\r\n', '123456', '');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cela`
--
ALTER TABLE `cela`
  ADD PRIMARY KEY (`Id`);

--
-- Índices de tabela `detento`
--
ALTER TABLE `detento`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `CelaId` (`CelaId`),
  ADD KEY `PenaId` (`PenaId`),
  ADD KEY `EstadoEmocionalId` (`EstadoEmocionalId`);

--
-- Índices de tabela `estadoemocional`
--
ALTER TABLE `estadoemocional`
  ADD PRIMARY KEY (`Id`);

--
-- Índices de tabela `pena`
--
ALTER TABLE `pena`
  ADD PRIMARY KEY (`Id`);

--
-- Índices de tabela `pergunta`
--
ALTER TABLE `pergunta`
  ADD PRIMARY KEY (`Id`);

--
-- Índices de tabela `respostapergunta`
--
ALTER TABLE `respostapergunta`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `DetentoId` (`DetentoId`),
  ADD KEY `PerguntaId` (`PerguntaId`);

--
-- Índices de tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cela`
--
ALTER TABLE `cela`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `detento`
--
ALTER TABLE `detento`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `estadoemocional`
--
ALTER TABLE `estadoemocional`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pena`
--
ALTER TABLE `pena`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pergunta`
--
ALTER TABLE `pergunta`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `respostapergunta`
--
ALTER TABLE `respostapergunta`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `detento`
--
ALTER TABLE `detento`
  ADD CONSTRAINT `detento_ibfk_1` FOREIGN KEY (`CelaId`) REFERENCES `cela` (`Id`),
  ADD CONSTRAINT `detento_ibfk_2` FOREIGN KEY (`PenaId`) REFERENCES `pena` (`Id`),
  ADD CONSTRAINT `detento_ibfk_3` FOREIGN KEY (`EstadoEmocionalId`) REFERENCES `estadoemocional` (`Id`);

--
-- Restrições para tabelas `respostapergunta`
--
ALTER TABLE `respostapergunta`
  ADD CONSTRAINT `respostapergunta_ibfk_1` FOREIGN KEY (`DetentoId`) REFERENCES `detento` (`Id`),
  ADD CONSTRAINT `respostapergunta_ibfk_2` FOREIGN KEY (`PerguntaId`) REFERENCES `pergunta` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
