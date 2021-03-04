﻿namespace FeriaVirtual.Domain.SeedWork.Command
{
    public interface ICommandHandler<TCommand>
        where TCommand:ICommand
    {
        void Handle(TCommand command);


    }
}
