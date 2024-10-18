//Listas
/* using System;
using System.Collections.Generic;

class lista
{
    static void Main()
    {
        List<int> lista = new List<int>();
        lista.Add(1);
        lista.Add(2);
        lista.Add(3);

        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }
}

 */

//listas Enlazadas
/* using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<int> listaEnlazada = new LinkedList<int>();
        listaEnlazada.AddLast(1);
        listaEnlazada.AddLast(2);
        listaEnlazada.AddLast(3);

        foreach (var item in listaEnlazada)
        {
            Console.WriteLine(item);
        }
    }
} */
//Listas Doblemente enlazadas
/* public class Nodo<T>
{
    public T Valor;
    public Nodo<T> Siguiente;
    public Nodo<T> Anterior;

    public Nodo(T valor)
    {
        Valor = valor;
    }
}

public class ListaDoblementeEnlazada<T>
{
    private Nodo<T> cabeza;

    public void Agregar(T valor)
    {
        Nodo<T> nuevoNodo = new Nodo<T>(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo<T> temp = cabeza;
            while (temp.Siguiente != null)
            {
                temp = temp.Siguiente;
            }
            temp.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = temp;
        }
    }
} */

//Listas Circulares
/* public class NodoCircular<T>
{
    public T Valor;
    public NodoCircular<T> Siguiente;

    public NodoCircular(T valor)
    {
        Valor = valor;
        Siguiente = this; // Apunta a sí mismo inicialmente
    }
}

public class ListaCircular<T>
{
    private NodoCircular<T> cabeza;

    public void Agregar(T valor)
    {
        NodoCircular<T> nuevoNodo = new NodoCircular<T>(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            NodoCircular<T> temp = cabeza;
            while (temp.Siguiente != cabeza)
            {
                temp = temp.Siguiente;
            }
            temp.Siguiente = nuevoNodo;
            nuevoNodo.Siguiente = cabeza; // Crea la circularidad
        }
    }
} */

//Listas doblemente circulaes
/* public class NodoDoblementeCircular<T>
{
    public T Valor;
    public NodoDoblementeCircular<T> Siguiente;
    public NodoDoblementeCircular<T> Anterior;

    public NodoDoblementeCircular(T valor)
    {
        Valor = valor;
    }
}

public class ListaDoblementeCircular<T>
{
    private NodoDoblementeCircular<T> cabeza;

    public void Agregar(T valor)
    {
        NodoDoblementeCircular<T> nuevoNodo = new NodoDoblementeCircular<T>(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
            nuevoNodo.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = nuevoNodo;
        }
        else
        {
            NodoDoblementeCircular<T> ultimo = cabeza.Anterior;
            ultimo.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = ultimo;
            nuevoNodo.Siguiente = cabeza;
            cabeza.Anterior = nuevoNodo;
        }
    }

    public void MostrarLista()
    {
        if (cabeza == null) return;

        NodoDoblementeCircular<T> temp = cabeza;
        do
        {
            Console.WriteLine(temp.Valor);
            temp = temp.Siguiente;
        } while (temp != cabeza);
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        ListaDoblementeCircular<int> listaDoblementeCircular = new ListaDoblementeCircular<int>();
        listaDoblementeCircular.Agregar(1);
        listaDoblementeCircular.Agregar(2);
        listaDoblementeCircular.Agregar(3);
        listaDoblementeCircular.MostrarLista();
    }
} */

//Lista circular enlazada
/* 
public class NodoCircularEnlazado<T>
{
    public T Valor;
    public NodoCircularEnlazado<T> Siguiente;
    public NodoCircularEnlazado<T> Anterior;

    public NodoCircularEnlazado(T valor)
    {
        Valor = valor;
        Siguiente = this; // Apunta a sí mismo inicialmente
        Anterior = this; // Apunta a sí mismo inicialmente
    }
}

public class ListaCircularEnlazada<T>
{
    private NodoCircularEnlazado<T> cabeza;

    public void Agregar(T valor)
    {
        NodoCircularEnlazado<T> nuevoNodo = new NodoCircularEnlazado<T>(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            NodoCircularEnlazado<T> temp = cabeza;
            while (temp.Siguiente != cabeza)
            {
                temp = temp.Siguiente;
            }
            temp.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = temp;
            nuevoNodo.Siguiente = cabeza; // Crea la circularidad
            cabeza.Anterior = nuevoNodo; // Actualiza el anterior de la cabeza
        }
    }

    public void MostrarLista()
    {
        if (cabeza == null) return;

        NodoCircularEnlazado<T> temp = cabeza;
        do
        {
            Console.WriteLine(temp.Valor);
            temp = temp.Siguiente;
        } while (temp != cabeza);
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        ListaCircularEnlazada<int> listaCircularEnlazada = new ListaCircularEnlazada<int>();
        listaCircularEnlazada.Agregar(1);
        listaCircularEnlazada.Agregar(2);
        listaCircularEnlazada.Agregar(3);
        listaCircularEnlazada.MostrarLista();
    }
} */