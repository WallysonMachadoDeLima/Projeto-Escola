﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Escola.Models
{
    public class Escola
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Razao { get; set; }

        public string Cnpj { get; set; }

        public string Inscricao_est { get; set; }

        public string Tipo { get; set; }

        public DateTime? Data_criacao { get; set; }

        public string Responsavel { get; set; }

        public string Telefone_res { get; set; }

        public string Email { get; set; }

        public string Telefone_esc { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        /*  create table Escola(
            id_esc int primary key auto_increment,
            nome_fantasia_esc varchar(255) not null,
            razao_social_esc varchar(255) not null,
            cnpj_esc varchar(18) not null,
            insc_estadual_esc varchar(255) null,
            tipo_esc varchar(20) not null,
            data_criacao_esc date not null,
            responsavel_esc varchar(300) not null,
            responsavel_telefone_esc varchar(30) not null,
            email_esc varchar(300) null,
            telefone_esc varchar(30) not null,
            rua_esc varchar(300) not null,
            numero_esc varchar(300) not null,
            bairro_esc varchar(300) not null,
            complemento_esc varchar(300) not null,
            cep_esc varchar(300) not null,
            cidade_esc varchar(300) not null,
            estado_esc varchar(300) not null);
                 */
    }
}
