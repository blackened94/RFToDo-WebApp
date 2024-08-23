﻿namespace RFToDo.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public byte Estado { get; set; }
        public int IdMeta { get; set; }
        public bool EstaSeleccionada { get; set; }
    }
}
