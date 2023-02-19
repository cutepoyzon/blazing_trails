using FluentValidation;

namespace BlazingTrails.Shared.Features.ManageTrails
{
    public class TrailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Location { get; set; } = "";
        public int TimeInMinutes { get; set; }
        public int Length { get; set; }
        public List<RouteInstruction> Route { get; set; } = new List<RouteInstruction>();
<<<<<<< HEAD

=======
        
>>>>>>> e001945030587c4de1cbf4469b346017bab2bde0
        public class RouteInstruction
        {
            public int Stage { get; set; }
            public string Description { get; set; } = "";
        }
<<<<<<< HEAD
    }

    /// <summary>
    /// It seems FluentValidation.AspNetCore is not compatible with Blazor Client Project - Microsoft.NET.Sdk.BlazorWebAssembly 
    /// which reference the librabry, so beware of all projects referenced in your 
    /// Blazor project so they don't contain incompatible packages.
    /// Use FluentValidation in the class Library peo
    /// </summary>
    public class TrailValidator : AbstractValidator<TrailDto>
    {
        public TrailValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter a name");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please enter a description");
            RuleFor(x => x.Location).NotEmpty().WithMessage("Please enter a location");
            RuleFor(x => x.Length).GreaterThan(0).WithMessage("Please enter a length");
            RuleForEach(x => x.Route).SetValidator(new RouteInstructionValidator());
        }
    }

    public class RouteInstructionValidator : AbstractValidator<TrailDto.RouteInstruction>
    {
        public RouteInstructionValidator()
        {
            RuleFor(x => x.Stage).NotEmpty().WithMessage("Please enter a stage");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please enter a description");
        }
=======
>>>>>>> e001945030587c4de1cbf4469b346017bab2bde0
    }
}
