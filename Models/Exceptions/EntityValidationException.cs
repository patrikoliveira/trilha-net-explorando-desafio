﻿namespace DesafioProjetoHospedagem.Models.Exceptions;

public class EntityValidationException : Exception
{
    public EntityValidationException(string? message) : base(message)
    {
    }
}

