using System;

internal class AuthorizeAttribute : Attribute
{
    public string Roles { get; set; }
}