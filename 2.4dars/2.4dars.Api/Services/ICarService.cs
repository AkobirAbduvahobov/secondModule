using _2._4dars.Api.Models;

namespace _2._4dars.Api.Services;

public interface ICarService
{
    public Car AddCar(Car car);
    public bool DeleteCar(int id);
    public bool UpdateCar(Car car);
    public List<Car> GetCars();
}
