using System.Collections.Generic;

namespace Identity.Domain.Entities
{
    public abstract class Base
    {
        public long Id { get; set; }

        //gera uma lista de erros para que as entidades se auto validatem
        internal List<string>? _errors;
        // le as propriedades acima
        public IReadOnlyCollection<string> Errors => _errors;
        public abstract bool Validate();
    }
}