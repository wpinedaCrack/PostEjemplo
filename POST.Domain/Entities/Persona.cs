﻿using System;
using System.Collections.Generic;

namespace POST.Domain.Entities;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int? Edad { get; set; }

    public string? Email { get; set; }
}
