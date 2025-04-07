using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace PilaGrafica_real_no_fake_
{
    public class TaulaLlista<T> : ICollection<T>, IList<T>
    {
        public const int DEFAULT_SIZE = 10;
        private T[] dades;
        private int nElem;

        /// <summary>
        /// Obté el nombre d'elements a la col·lecció.
        /// </summary>
        public int Count
        {
            get { return nElem; }

        }

        /// <summary>
        /// Indica si la col·lecció és només de lectura.
        /// </summary>
        public bool IsReadOnly
        {
            get { return false; }
        }


        /// <summary>
        /// Obté o estableix l'element a l'índex especificat a la col·lecció.
        /// Llança una excepció ArgumentOutOfRangeException si l'índex està fora de rang.
        /// </summary>
        /// <param name="index">L'índex de l'element a obtenir o establir.</param>
        /// <returns>L'element a l'índex especificat.</returns>
        /// <exception cref="ArgumentOutOfRangeException">S'engega quan l'índex és menor que 0 o més gran o igual que la llargada de la col·lecció.</exception>

        public T this[int index]
        {
            get
            {
                if (IsReadOnly) throw new NotSupportedException("La col·lecció és únicament de lectura i no es poden afegir elements");
                if (index < 0 || index >= nElem)
                    throw new ArgumentOutOfRangeException("Index fora del rang.");

                return dades[index];
            }
            set
            {
                if (IsReadOnly) throw new NotSupportedException("La col·lecció és únicament de lectura i no es poden afegir elements");
                if (index < 0 || index >= nElem)
                    throw new ArgumentOutOfRangeException("Index fora del rang.");

                dades[index] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrayDeDades"></param>
        public TaulaLlista(T[] arrayDeDades)
        {
            dades = new T[arrayDeDades.Length * 2];
            nElem = arrayDeDades.Length;


            for (int i = 0; i < nElem; i++)
            {
                dades[i] = arrayDeDades[i];
            }
        }
        /// <summary>
        /// Constructor que inicialitza la col·lecció amb una capacitat especificada.
        /// </summary>
        /// <param name="capacitatInicial">Capacitat inicial de la col·lecció.</param>
        public TaulaLlista(int capacitatInicial)
        {
            dades = new T[capacitatInicial];
            nElem = 0;
        }

        /// <summary>
        /// Constructor que inicialitza la col·lecció amb una capacitat per defecte (10).
        /// </summary>
        public TaulaLlista() : this(DEFAULT_SIZE) { }

        /// <summary>
        /// Constructor que crea una nova instància de la col·lecció a partir d'una altra.
        /// </summary>
        /// <param name="TaulaLlista2">Una altra instància de TaulaLlista per copiar els seus elements.</param>
        public TaulaLlista(TaulaLlista<T> TaulaLlista2)
        {
            dades = new T[TaulaLlista2.dades.Length];
            nElem = TaulaLlista2.nElem;
            for (int i = 0; i < nElem; i++)
            {
                dades[i] = TaulaLlista2.dades[i];
            }
        }

        /// <summary>
        /// Obté un enumerador per recórrer la col·lecció.
        /// </summary>
        /// <returns>Un enumerador que recorre els elements de la col·lecció en ordre invers.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            //for (int i = 0; i < nElem; i++)
            //{
            //    yield return dades[i];
            //}

            return new ElMeuEnumerador(this.dades, this.nElem);
        }


        public class ElMeuEnumerador : IEnumerator<T>
        {
            private int limit;
            private int posicio;
            private T[] dades;

            public ElMeuEnumerador(T[] dades, int nElem)
            {
                this.dades = dades;
                this.posicio = -1;
                this.limit = nElem;
            }

            public T Current
            {
                get
                {
                    if (posicio == -1 || posicio >= limit) throw new Exception("OUT OF RANGE");
                    return dades[posicio];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            public void Dispose()
            {
                this.dades = null;
            }

            public bool MoveNext()
            {
                bool hiHaSeguent = true;
                posicio++;
                if (posicio >= limit) hiHaSeguent = false;
                return hiHaSeguent;
            }

            public void Reset()
            {
                posicio = -1;
            }
        }

        /// <summary>
        /// Obté un enumerador de la col·lecció. Aquest mètode no està implementat, ja que 
        /// s'utilitza el mètode <see cref="GetEnumerator"/> per obtenir l'enumerador de la col·lecció.
        /// </summary>
        /// <returns>No implementat.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Métode ToString amb IEnumerator
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sOut = new StringBuilder("[ ");
            IEnumerator<T> enumerador = this.GetEnumerator();
            bool primerElement = true;

            while (enumerador.MoveNext())
            {
                if (!primerElement)
                {
                    sOut.Append(", ");
                }
                sOut.Append(enumerador.Current.ToString());
                primerElement = false;
            }

            sOut.Append(" ]");
            return sOut.ToString();
        }




        /// <summary>
        /// Duplica la capacitat de l'b array "dades" duplicant la seva longitud i copiant els elements existents.
        /// </summary>
        private void DuplicaCapacitat()
        {
            T[] dadesNova = new T[dades.Length * 2];
            for (int i = 0; i < nElem; i++)
            {
                dadesNova[i] = dades[i];
            }
            dades = dadesNova;
        }

        /// <summary>
        /// Afegeix un nou element al final de la col·lecció.
        /// Si la col·lecció està plena, es duplica la capacitat abans d'afegir l'element.
        /// </summary>
        /// <param name="item">Element a afegir.</param>
        /// <exception cref="NotSupportedException">Llança una excepció si la col·lecció és només de lectura.</exception>
        public void Add(T item)
        {

            if (IsReadOnly) throw new NotSupportedException("La col·lecció és únicament de lectura i no es poden afegir elements");
            if (nElem == dades.Length) DuplicaCapacitat();

            dades[nElem] = item;
            nElem++;
        }

        /// <summary>
        /// Elimina tots els elements de la col·lecció.
        /// Si la col·lecció és només de lectura, llança una excepció.
        /// </summary>
        /// <exception cref="NotSupportedException">Llança una excepció si la col·lecció és només de lectura.</exception>
        public void Clear()
        {
            int i;
            if (IsReadOnly) throw new NotSupportedException("La col·lecció és únicament de lectura i no es poden eliminar elements");

            for (i = 0; i < nElem; i++)
            {
                dades[i] = default(T);
            }
            nElem = 0; ;
        }

        /// <summary>
        /// Comprova si un element es troba a la col·lecció.
        /// </summary>
        /// <param name="item">Element a cercar.</param>
        /// <returns>Retorna un valor booleà que indica si l'element existeix a la col·lecció.</returns>
        public bool Contains(T item)
        {
            bool trobat = false;
            int index = IndexOf(item);


            if (index != -1)
            {
                trobat = true;
            }

            return trobat;
        }


        /// <summary>
        /// Copia els elements de la col·lecció a un array.
        /// </summary>
        /// <param name="array">Array de destinació on es copiaran els elements.</param>
        /// <param name="arrayIndex">Índex inicial de l'array on començar a copiar.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null) throw new ArgumentNullException("L'array no pot ser null");
            if (arrayIndex < 0) throw new ArgumentOutOfRangeException("L'array no pot estár buit");
            if (arrayIndex + nElem > array.Length) throw new ArgumentException("No hi ha espai en l'array");


            for (int i = 0; i < nElem; i++)
            {
                array[arrayIndex + i] = dades[i];
            }
        }

        /// <summary>
        /// Elimina un element de la col·lecció.
        /// </summary>
        /// <param name="item">Element a eliminar.</param>
        /// <returns>Retorna un valor booleà que indica si l'element ha estat eliminat amb èxit.</returns>
        public bool Remove(T item)
        {
            bool trobat = false;
            if (IsReadOnly) throw new NotSupportedException("La col·lecció és únicament de lectura i no es poden eliminar elements");
            int i = IndexOf(item);



            if (i != -1)
            {
                trobat = true;
                if (trobat)
                {
                    for (int j = i; j < nElem - 1; j++)
                    {
                        dades[j] = dades[j + 1];
                    }

                    dades[nElem - 1] = default(T);
                    nElem--;
                }
            }

            return trobat;
        }


        /// <summary>
        /// Cerca l'element especificat a la col·lecció i retorna l'índex de la seva primera ocurrència.
        /// Retorna -1 si l'element no es troba.
        /// </summary>
        /// <param name="item">L'element a localitzar a la col·lecció.</param>
        /// <returns>L'índex de l'element si es troba; sinó, -1.</returns>
        public int IndexOf(T item)
        {
            int index = 0;
            bool trobat = false;
            while (!trobat && index < nElem)
            {
                if (dades[index].Equals(item))
                    trobat = true;
                else index++;
            }

            if (!trobat) index = -1;
            return index;
        }

        /// <summary>
        /// Insereix un element a l'índex especificat de la col·lecció. Desplaça els elements següents a la dreta.
        /// Llança una excepció si l'índex està fora de rang o si la col·lecció és només de lectura.
        /// </summary>
        /// <param name="index">L'índex basat en 0 on s'ha d'inserir l'element.</param>
        /// <param name="item">L'element a inserir a la col·lecció.</param>
        /// <exception cref="ArgumentOutOfRangeException">Slançada si l'índex és menor que 0 o superior al nombre d'elements de la col·lecció.</exception>
        /// <exception cref="NotSupportedException">Slançada si la col·lecció és només de lectura.</exception>
        public void Insert(int index, T item)
        {
            if (index < 0 || index > nElem)
            {
                throw new ArgumentOutOfRangeException("Índex fora del rang.");
            }

            if (IsReadOnly) throw new NotSupportedException("La col·lecció és únicament de lectura i no es poden eliminar elements");

            if (nElem == dades.Length) DuplicaCapacitat();

            for (int i = nElem; i > index; i--)
            {
                dades[i] = dades[i - 1];
            }
            dades[index] = item;
            nElem++;
        }

        /// <summary>
        /// Elimina l'element a l'índex especificat de la col·lecció i desplaça els elements següents a l'esquerra.
        /// Llança una excepció si l'índex està fora de rang o si la col·lecció és només de lectura.
        /// </summary>
        /// <param name="index">L'índex basat en 0 de l'element a eliminar.</param>
        /// <exception cref="NotSupportedException">Slançada si la col·lecció és només de lectura.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Slançada si l'índex està fora de rang.</exception>
        public void RemoveAt(int index)
        {
            if (IsReadOnly)
                throw new NotSupportedException("La col·lecció és únicament de lectura i no es poden eliminar elements");

            if (index >= 0 && index < nElem)
            {
                for (int i = index; i < nElem - 1; i++)
                {
                    dades[i] = dades[i + 1];
                }

                dades[nElem] = default(T);
                nElem--;

            }
            else
            {
                throw new ArgumentOutOfRangeException("El index fora de rang.");
            }
        }

    }
}








