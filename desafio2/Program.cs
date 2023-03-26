using System;

interface INotificable
{
    void Notifica(string mensaje);
}

class NotificacionEmail : INotificable
{
    public string direccionCorreo;

    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando email a {direccionCorreo}: {mensaje}");
        // Aquí iría el código para enviar un email a la dirección especificada
    }
}

class NotificacionWhatsap : INotificable
{
    public string numeroTelefono;

    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando mensaje por WhatsApp a {numeroTelefono}: {mensaje}");
        // Aquí iría el código para enviar un mensaje por WhatsApp al número especificado
    }
}

class NotificacionSMS : INotificable
{
    public string numeroTelefono;

    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando SMS a {numeroTelefono}: {mensaje}");
        // Aquí iría el código para enviar un SMS al número especificado
    }
}

class Program
{
    static void Main(string[] args)
    {
        var notificacionEmail = new NotificacionEmail { direccionCorreo = "umg@ejemplo.com" };
        var notificacionWhatsap = new NotificacionWhatsap { numeroTelefono = "1346223333" };
        var notificacionSMS = new NotificacionSMS { numeroTelefono = "1346223333" };

        notificacionEmail.Notifica("Hola desde INotificable ");
        notificacionWhatsap.Notifica("Hola desde INotificable ");
        notificacionSMS.Notifica("Hola desde INotificable ");
    }
}
