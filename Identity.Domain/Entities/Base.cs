using System.Collections.Generic;


// essa entidade será inserida em User, para que eles utilizem os recursos, por isso é uma abstract class
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