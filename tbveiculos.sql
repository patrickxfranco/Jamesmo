-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Tempo de geração: 16-Abr-2022 às 18:27
-- Versão do servidor: 5.7.33
-- versão do PHP: 7.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `dbjamesmo`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbveiculos`
--

CREATE TABLE `tbveiculos` (
  `idVeiculo` int(11) NOT NULL,
  `marcaVeiculo` varchar(20) DEFAULT NULL,
  `modeloVeiculo` varchar(20) DEFAULT NULL,
  `anoVeiculo` varchar(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tbveiculos`
--

INSERT INTO `tbveiculos` (`idVeiculo`, `marcaVeiculo`, `modeloVeiculo`, `anoVeiculo`) VALUES
(1, 'VOLKSWAGEN', 'VOYAGE', '2012'),
(2, 'VOLKSWAGEN', 'GOL', '2009');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tbveiculos`
--
ALTER TABLE `tbveiculos`
  ADD PRIMARY KEY (`idVeiculo`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tbveiculos`
--
ALTER TABLE `tbveiculos`
  MODIFY `idVeiculo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
