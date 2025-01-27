﻿namespace IWantApp.EndPoints.Categories;

public record CategoryResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
};
