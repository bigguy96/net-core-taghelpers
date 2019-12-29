using System.Collections.Generic;

namespace TagHelperCore.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Department> Departments { get; set; }

        public static IEnumerable<Store> CreateList()
        {
            return new List<Store>()
            {
                new Store
                {
                    Id = 1,
                    Name = "Store1",
                    Departments = new List<Department>()
                    {
                        new Department
                        {
                            Id = 1,
                            Name ="D1"
                        },
                        new Department
                        {
                            Id = 2,
                            Name ="D2"
                        },
                        new Department
                        {
                            Id = 3,
                            Name ="D3"
                        }
                    }
                },
                new Store
                {
                    Id = 2,
                    Name = "Store2",
                    Departments = new List<Department>()
                    {
                        new Department
                        {
                            Id = 11,
                            Name ="D1"
                        },
                        new Department
                        {
                            Id = 22,
                            Name ="D2"
                        },
                        new Department
                        {
                            Id = 33,
                            Name ="D3"
                        }
                    }
                },
                new Store
                {
                    Id = 3,
                    Name = "Store3",
                    Departments = new List<Department>()
                    {
                        new Department
                        {
                            Id = 111,
                            Name ="D1"
                        },
                        new Department
                        {
                            Id = 222,
                            Name ="D2"
                        },
                        new Department
                        {
                            Id = 333,
                            Name ="D3"
                        }
                    }
                }
            };
        }
    }
}
