﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTCPayServer.Models.AccountViewModels
{
    public class LoginWithRecoveryCodeViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Código de recuperación")]
        public string RecoveryCode { get; set; }
    }
}
