﻿using Calculations.Domain;
using Calculations.Hub;
using Calculations.Hub.Client;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace Calculations.Hub;

public class CalculationHub : Hub<ICalculationClient>, ICalculationHub
{
    private readonly IMediator _mediator;

    public CalculationHub(IMediator mediator)
    {
        _mediator = mediator;
    }

    // public async Task CalculateEquations(CalculateEquationsCommand command)
    // {
    //     await _mediator.Send(command);
    // }

    public Task<List<CalculationResult>> GetHistory()
    {
        throw new NotImplementedException();
    }
}