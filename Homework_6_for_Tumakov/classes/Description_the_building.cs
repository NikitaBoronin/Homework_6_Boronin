

namespace Homework_6_for_Tumakov
{
    internal class Description_the_building
    {
        #region Поля
        private static int _buildingNumberId = 1;
        private int _idBuilding;
        private int _height;
        private int _floor;
        private int _numberOfApartments;
        private int _numberOfEntrances;
        #endregion

        #region Свойства
        public int IdBuilding => _idBuilding;
        #endregion

        #region Методы
        private void GenerateId()
        {
            _idBuilding = _buildingNumberId++;
        }

        public void SetValues()
        {
            Console.WriteLine("Введите высоту здания (в метрах):");
            while (!int.TryParse(Console.ReadLine(), out _height) || _height <= 0)
            {
                Console.WriteLine("Ошибка! Введите корректное положительное целое число для высоты:");
            }

            Console.WriteLine("Введите количество этажей:");
            while (!int.TryParse(Console.ReadLine(), out _floor) || _floor <= 0)
            {
                Console.WriteLine("Ошибка! Введите корректное положительное целое число для этажей:");
            }

            Console.WriteLine("Введите количество квартир:");
            while (!int.TryParse(Console.ReadLine(), out _numberOfApartments) || _numberOfApartments <= 0)
            {
                Console.WriteLine("Ошибка! Введите корректное положительное целое число для квартир:");
            }

            Console.WriteLine("Введите количество подъездов:");
            while (!int.TryParse(Console.ReadLine(), out _numberOfEntrances) || _numberOfEntrances <= 0)
            {
                Console.WriteLine("Ошибка! Введите корректное положительное целое число для подъездов:");
            }

            if (_height / _floor < 2)
            {
                Console.WriteLine("Предупреждение: высота этажа слишком мала!");
            }
        }

        public void PrintValues()
        {
            Console.WriteLine($"ID здания: {_idBuilding}");
            Console.WriteLine($"Высота здания: {_height} м");
            Console.WriteLine($"Количество этажей: {_floor}");
            Console.WriteLine($"Количество квартир: {_numberOfApartments}");
            Console.WriteLine($"Количество подъездов: {_numberOfEntrances}");
        }

        public double CalculateFloorHeight()
        {
            if (_floor == 0) throw new InvalidOperationException($"{nameof(CalculateFloorHeight)}: Количество этажей не может быть нулевым.");
            return (double)_height / _floor;
        }

        public int CalculateApartmentsPerEntrance()
        {
            if (_numberOfEntrances == 0) throw new InvalidOperationException($"{nameof(CalculateApartmentsPerEntrance)}: Количество подъездов не может быть нулевым.");
            return _numberOfApartments / _numberOfEntrances;
        }

        public int CalculateApartmentsPerFloor()
        {
            if (_floor == 0) throw new InvalidOperationException($"{nameof(CalculateApartmentsPerFloor)}: Количество этажей не может быть нулевым.");
            return _numberOfApartments / _floor;
        }
        #endregion

        #region Конструктор
        public Description_the_building()
        {
            GenerateId();
        }
        #endregion
    }
}
