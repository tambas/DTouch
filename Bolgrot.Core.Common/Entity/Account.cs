﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ServiceStack.DataAnnotations;

namespace Bolgrot.Core.Common.Entity
{
    public class Account : AbstractEntity
    {
        [PrimaryKey, AutoIncrement]
        public override int Id { get; set; }
        
        public string Nickname { get; set; }
        
        public string Login { get; set; }
        
        public string Password { get; set; }
        
        public string Token { get; set; }
        
        public string Ticket { get; set; }
        
        public string ApiKey { get; set; }
        
        public string Ip { get; set; }
        
        [NotNull]
        public DateTime? ApiKeyExpirationDate { get; set; }
        
        [Default("CURRENT_TIMESTAMP()")]
        public DateTime CreationDate { get; set; }
    }
}