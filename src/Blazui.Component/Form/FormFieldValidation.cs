﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazui.Component.Form
{
    public class FormFieldValidation
    {
        public string Name { get; set; }
        public List<IValidationRule> Rules { get; set; } = new List<IValidationRule>();
    }
}
