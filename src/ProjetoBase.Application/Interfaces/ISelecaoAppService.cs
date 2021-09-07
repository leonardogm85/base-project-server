﻿using ProjetoBase.Infrastructure.CrossCutting.Common.Selects;
using System;

namespace ProjetoBase.Application.Interfaces
{
    public interface ISelecaoAppService<TKey, TValue>
        where TKey : IEquatable<TKey>
        where TValue : IEquatable<TValue>
    {
        SelectResult<TKey, TValue> ObterSelecao(params TKey[] identidades);
        SelectResult<TKey, TValue> ObterSelecao(SelectFilter filtro);
    }
}
