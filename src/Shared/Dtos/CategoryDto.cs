﻿using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Shared.Dtos;

public sealed class CategoryDto
{
    [Required] public string Name { get; set; } = null!;

    [Required] public string Uri { get; set; } = null!;
}