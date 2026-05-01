using Projeto2Ed;
using System;
using System.Collections.Generic;


public interface IHashing<T>
                 where T : IRegistro<T>, IEquatable<T>, new()
{
    public bool Incluiu(T novoDado);
    public bool Excluiu(T dadoAExcluir);
    public bool Existe(T dadoAProcurar, out int onde);
    public List<string> LocaisDosDados();
    public List<T> Conteudo();
}
