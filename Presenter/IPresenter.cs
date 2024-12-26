
using Microsoft.EntityFrameworkCore;

namespace App
{
    public interface IPresenter
    {
        public void ContextLoad();

        #region Tables Loaders
        public void SpecialtiesTableLoad();
        public void EmployeesTableLoad();
        public void OwnersTableLoad();
        public void CarsTableLoad();
        public void RequestsTableLoad();
        public void OrdersTableLoad();
        public void WorksTableLoad();
        public void SuppliersTableLoad();
        public void SuppliesTableLoad();
        public void PositionsTableLoad();
        public void PartsTableLoad();
        public void StoragePartsTableLoad();
        #endregion

        #region Tables to Lists
        public List<Specialty> SpecialtiesTableToList();
        public List<Employee> EmployeesTableToList();
        public List<Owner> OwnersTableToList();
        public List<Car> CarsTableToList();
        public List<Request> RequestsTableToList();
        public List<Order> OrdersTableToList();
        public List<Work> WorksTableToList();
        public List<Supplier> SuppliersTableToList();
        public List<Supply> SuppliesTableToList();
        public List<Position> PositionsTableToList();
        public List<Part> PartsTableToList();
        public List<Accounting> StoragePartsTableToList();
        #endregion

        #region Removing Methods
        public void SpecialtiesRemove(Specialty specialty);
        public void EmployeesRemove(Employee employee);
        public void OwnersRemove(Owner owner);
        public void CarsRemove(Car car);
        public void RequestsRemove(Request request);
        public void OrdersRemove(Order order);
        public void WorksRemove(Work work);
        public void SuppliersRemove(Supplier supplier);
        public void SuppliesRemove(Supply supply);
        public void PositionsRemove(Position position);
        public void PartsRemove(Part part);
        public void StoragePartsRemove(Accounting accounting);
        #endregion

        #region Adding Methods
        public void SpecialtiesAdd(Specialty specialty);
        public void EmployeesAdd(Employee employee);
        public void OwnersAdd(Owner owner);
        public void CarsAdd(Car car);
        public void RequestsAdd(Request request);
        public void OrdersAdd(Order order);
        public void WorksAdd(Work work);
        public void SuppliersAdd(Supplier supplier);
        public void SuppliesAdd(Supply supply);
        public void PositionsAdd(Position position);
        public void PartsAdd(Part part);
        public void StoragePartsAdd(Accounting accounting);
        #endregion

        #region Finding Methods
        public Specialty? SpecialtiesFind(int index);
        public Employee? EmployeesFind(int index);
        public Owner? OwnersFind(int index);
        public Car? CarsFind(int index);
        public Request? RequestsFind(int index);
        public Order? OrdersFind(int index);
        public Work? WorksFind(int index);
        public Supplier? SuppliersFind(int index);
        public Supply? SuppliesFind(int index);
        public Position? PositionsFind(int index1, int index2);
        public Part? PartsFind(int index);
        public Accounting? StoragePartsFind(int index);
        #endregion

        public List<Part> NomenclatureFind(int index);

        #region Entries Methods
        public void SpecialtiesEntry(Specialty specialty);
        public void EmployeesEntry(Employee employee);

        public void OwnersEntry(Owner owner);

        public void CarsEntry(Car car);

        public void RequestsEntry(Request request);

        public void OrdersEntry(Order order);

        public void WorksEntry(Work work);

        public void SuppliersEntry(Supplier supplier);

        public void SuppliesEntry(Supply supply);

        public void PositionsEntry(Position position);

        public void PartsEntry(Part part);

        public void StoragePartsEntry(Accounting accounting);
        #endregion

        public void ContextSaveChanges();

        public void ContextDispose();
    }
}
