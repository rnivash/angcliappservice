using Microsoft.AspNetCore.Mvc;

namespace angcliappservice.Controllers;

[ApiController]
[Route("[controller]")]
public class ConfigServiceController : ControllerBase
{
    private readonly ILogger<ConfigServiceController> _logger;

    public ConfigServiceController(ILogger<ConfigServiceController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Section> Get(string OrderCode)
    {
        var result = new List<Section>();
        if(OrderCode.Equals("100"))
        {
            GetOc100(result);
        }
        else if(OrderCode.Equals("200"))
        {
            GetOc200(result);
        }

        return result;
    }

    private static void GetOc100(List<Section> result)
    {
        result.Add(new Section
        {
            Id = 1,
            Name = "Component",
            Modules = new List<Module>{
                new Module{
                    Id=1,
                    Name="Processor",
                    IsMultiSelect =false,
                    Options = new List<Option>{
                        new Option{
                            Id=1,
                            Name="Intel I3",
                            Selected =true
                        },
                        new Option{
                            Id=1,
                            Name="Intel I5",
                            Selected =false
                        },
                        new Option{
                            Id=1,
                            Name="Intel I7",
                            Selected =false
                        }
                    }
                }
            }
        });
    }

    private static void GetOc200(List<Section> result)
    {
        result.Add(new Section
        {
            Id = 1,
            Name = "Component",
            Modules = new List<Module>{
                new Module{
                    Id=1,
                    Name="Processor",
                    IsMultiSelect =false,
                    Options = new List<Option>{
                        new Option{
                            Id=1,
                            Name="Intel I3",
                            Selected =true
                        },
                        new Option{
                            Id=1,
                            Name="Intel I5",
                            Selected =false
                        },
                        new Option{
                            Id=1,
                            Name="Intel I7",
                            Selected =false
                        }
                    }
                }
            }
        });
        result.Add(new Section
        {
            Id = 1,
            Name = "Services",
            Modules = new List<Module>{
                new Module{
                    Id=1,
                    Name="Processor",
                    IsMultiSelect =false,
                    Options = new List<Option>{
                        new Option{
                            Id=1,
                            Name="Intel I3",
                            Selected =true
                        },
                        new Option{
                            Id=1,
                            Name="Intel I5",
                            Selected =false
                        },
                        new Option{
                            Id=1,
                            Name="Intel I7",
                            Selected =false
                        }
                    }
                }
            }
        });
    }
}

public class Section{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<Module> Modules { get; set; }

}

public class Module{

     public int Id { get; set; }

    public string Name { get; set; }

    public List<Option> Options { get; set; }

    public bool IsMultiSelect { get; set; }


}

public class Option{
    public int Id { get; set; }

    public string Name { get; set; }

    public bool Selected { get; set; }
}


