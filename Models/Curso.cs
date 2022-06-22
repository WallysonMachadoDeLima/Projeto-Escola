﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Escola.Models
{
    public class Curso
    {
        public int Id { get; set;  }

        public string Nome { get; set; }

        public string CargaHoraria { get; set; }

        public string Descricao { get; set; }

        public string Turno { get; set; }

          /*
            create table Curso (
            id_cur int primary key auto_increment,
            nome_cur varchar (300) not null,
            descricao_cur varchar (300) not null,
            carga_horaria_cur varchar (300) not null,
            turno_cur varchar (300) not null
            );
         */
    }
}
