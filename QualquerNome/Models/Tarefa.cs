﻿namespace QualquerNome.Models
{
    public class Tarefa
    {
        // nome da chave primaria deve ser (Nome da classe + "Id")
        public int TarefaId { get; set; } //ID é a chave primaria
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public bool Concluida { get; set; }
    }
}
