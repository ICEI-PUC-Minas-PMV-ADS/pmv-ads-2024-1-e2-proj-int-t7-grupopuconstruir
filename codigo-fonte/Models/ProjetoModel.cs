using System;
using PUConstruir.Controllers;
using PUConstruir.Repositorio;
using Microsoft.Identity.Client;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PUConstruir.Models;
{
    public class ProjetoModel
    {
        private int _IdProjeto { get; set; }
        public int IdProjeto { get => _IdProjeto; set => _IdProjeto = value; }

        private string _NomeProjeto;
        public string NomeProjeto { get => _NomeProjeto; set => _NomeProjeto = value; }
        
        private string _Descricao;
        public string Descricao { get => _Descricao; set => _Descricao = value; }

        private DateOnly _DataInicial;
        public DateOnly DataInicial { get => _DataInicial; set => _DataInicial = value; }
        
        private DateOnly _DataFinal;
        public DateOnly DataFinal { get => _DataFinal; set => _DataFinal = value; }

        private decimal _Valor;
        public decimal Valor { get => _Valor; set => _Valor = value; }

        //Falta usuario, Data de criação e Materiais?
    }
}