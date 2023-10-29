﻿using ToDoListASP.Enums;

namespace ToDoListASP.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public StatusTarefa Status { get; set; }
    }
}
