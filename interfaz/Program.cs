using System;
public interface INotificable
{
    void Notificar();
}

public class NotificacionEmail : INotificable
{
    public string DireccionCorreo { get; set; }

    public void Notificar()
    {
        Console.WriteLine($"Enviando notificación por correo a {DireccionCorreo}");
    }
}

public class NotificacionWhatsap : INotificable
{
    public string NumeroTelefono { get; set; }

    public void Notificar()
    {
        Console.WriteLine($"Enviando notificación por WhatsApp a {NumeroTelefono}");
    }
}

public class NotificacionSMS : INotificable
{
    public string NumeroTelefono { get; set; }

    public void Notificar()
    {
        Console.WriteLine($"Enviando notificación por SMS a {NumeroTelefono}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var notificacionEmail = new NotificacionEmail
        {
            DireccionCorreo = "lesterlopez846@gmail.com"
        };
        notificacionEmail.Notificar();

        var notificacionWhatsapp = new NotificacionWhatsap
        {
            NumeroTelefono = "+502 5334 4812"
        };
        notificacionWhatsapp.Notificar();

        var notificacionSMS = new NotificacionSMS
        {
            NumeroTelefono = "+502 5334 4812"
        };
        notificacionSMS.Notificar();
    }
}
