using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Q7
{
    public class Propriedades
    {
        private string path;
        private IDictionary<string, string> propriedades = new Dictionary<string, string>();

        public string Path { get => path; private set => path = value; }
        public IDictionary<string, string> _Propriedades { get => propriedades; private set => propriedades = value; }

        public Propriedades()
        {

        }

        public Propriedades(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("O arquivo não existe");
            }

            Path = path;

            var valores = File.ReadLines(Path)
                .Select(linhas => linhas
                .Split(new char[] { '=' }, 2))
                .Where(propriedades => propriedades.Length == 2);

            foreach(var v in valores)
            {
                _Propriedades.Add(v[0], v[1]);
            }
        }

        public string PegarValorDeChave(string chave)
        {
            if (ChaveExiste(chave))
                return _Propriedades[chave];

            return null;
        }

        public void AlterarValorDeChave(string chave, string valor)
        {
            if (ChaveExiste(chave))
            {
                _Propriedades[chave] = valor;
                Console.WriteLine("Valor alterado com sucesso!");
            } else
            {
                Console.WriteLine("Chave não existe");
            }
                
        }

        public bool ChaveExiste(string chave)
        {
            return _Propriedades.TryGetValue(chave, out string c);
        }

        public void SalvarPropriedades()
        {
            string propriedades = "";
            foreach (KeyValuePair<string, string> propriedade in _Propriedades)
                propriedades += propriedade.Key + "=" + propriedade.Value + "\n";
            File.WriteAllText(Path, propriedades);
            Console.WriteLine("Propriedades salvas com sucesso!");
        }
    }
}
