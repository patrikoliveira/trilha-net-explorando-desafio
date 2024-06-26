﻿using DesafioProjetoHospedagem.Models.Exceptions;
using DesafioProjetoHospedagem.Models.Shareds;

namespace DesafioProjetoHospedagem.Models.Validation;

public class DomainValidation
{
    public static void NotNull(object? target, string fieldName)
    {
        if (target is null)
        {
            throw new EntityValidationException($"{fieldName} não pode ser nulo");
        }
    }

    public static void NotNullOrEmpty(string? target, string fieldName)
    {
        if (String.IsNullOrWhiteSpace(target))
        {
            throw new EntityValidationException($"{fieldName} não pode ser vazio ou nulo");
        }
    }

    public static void MinLength(string target, int minLength, string fieldName)
    {
        if (target.Length < minLength)
        {
            throw new EntityValidationException($"{fieldName} deve ter pelo menos {minLength} caracteres");
        }
    }

    public static void MaxLength(string target, int maxLength, string fieldName)
    {
        if (target.Length > maxLength)
        {
            throw new EntityValidationException($"{fieldName} deve ser menor ou igual a {maxLength} caracteres");
        }
    }

    public static void NotLessThanOrEqualZero(decimal target, string fieldName)
    {
        if (target <= decimal.Zero)
        {
            throw new EntityValidationException($"{fieldName} não pode ser menor ou igual a zero");
        }
    }

    public static void NotLessThanOrEqualZero(int target, string fieldName)
    {
        if (target <= Constants.ZERO)
        {
            throw new EntityValidationException($"{fieldName} não pode ser menor ou igual a zero");
        }
    }

    public static void NotLessThanAnotherField(int source, string fieldNameSource, int target, string fieldNameTarget)
    {
        if (source < target)
        {
            throw new EntityValidationException($"{fieldNameSource} não pode ser menor que {fieldNameTarget}");
        }
    }
}

