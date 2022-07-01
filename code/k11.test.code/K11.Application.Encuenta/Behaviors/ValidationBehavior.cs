using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace K11.Application.Encuenta.Behaviors
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {        
        private readonly IEnumerable<IValidator<TRequest>> _validatiors;
        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validatiors)
        {
            _validatiors = validatiors;
        }
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            
            if (_validatiors.Any())
            {
                
                var context = new FluentValidation.ValidationContext<TRequest>(request);                
                var validationResults = await Task.WhenAll(_validatiors.Select(v => v.ValidateAsync(context, cancellationToken)));                
                var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();
                if (failures.Count != 0)
                {                    
                    throw new Exceptions.ValidationException(failures);
                }
            }
            return await next();
        }
    }
}
