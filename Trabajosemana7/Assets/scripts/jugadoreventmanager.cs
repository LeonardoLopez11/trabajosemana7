using System;

public class jugadoreventmanager 
{
    public event Action JugadorCreado;

    public void OnJugadorCreado()
    {
        JugadorCreado?.Invoke();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
