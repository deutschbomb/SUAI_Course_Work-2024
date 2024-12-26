
using Microsoft.EntityFrameworkCore;

namespace App
{
    public class Presenter : IPresenter
    {
        public IView View;
        public Context? db;

        public Presenter(IView View)
        {
            this.View = View;
        }

        public void ContextLoad()
        {
            this.db = new Context();
            this.db.Database.EnsureCreated();
        }

        #region Tables Loaders
        public void SpecialtiesTableLoad() { this.db.Specialties.Load(); }
        public void EmployeesTableLoad() { this.db.Employees.Load(); }
        public void OwnersTableLoad() { this.db.Owners.Load(); }
        public void CarsTableLoad() { this.db.Cars.Load(); }
        public void RequestsTableLoad() { this.db.Requests.Load(); }
        public void SuppliersTableLoad() { this.db.Suppliers.Load(); }
        public void SuppliesTableLoad() { this.db.Supplies.Load(); }
        public void PositionsTableLoad() { this.db.Positions.Load(); }
        public void PartsTableLoad() { this.db.Parts.Load(); }
        public void StoragePartsTableLoad() { this.db.StorageParts.Load(); }
        #endregion

        #region Tables to Lists
        public List<Specialty> SpecialtiesTableToList() { return this.db.Specialties.Local.ToList(); }
        public List<Employee> EmployeesTableToList() { return this.db.Employees.Local.ToList(); }
        public List<Owner> OwnersTableToList() { return this.db.Owners.Local.ToList(); }
        public List<Car> CarsTableToList() { return this.db.Cars.Local.ToList(); }
        public List<Request> RequestsTableToList() { return this.db.Requests.Local.ToList(); }
        public List<Supplier> SuppliersTableToList() { return this.db.Suppliers.Local.ToList(); }
        public List<Supply> SuppliesTableToList() { return this.db.Supplies.Local.ToList(); }
        public List<Position> PositionsTableToList() { return this.db.Positions.Local.ToList(); }
        public List<Part> PartsTableToList() { return this.db.Parts.Local.ToList(); }
        public List<Accounting> StoragePartsTableToList() { return this.db.StorageParts.Local.ToList(); }
        #endregion

        #region Removing Methods
        public void SpecialtiesRemove(Specialty specialty) { this.db.Specialties.Remove(specialty); }
        public void EmployeesRemove(Employee employee) { this.db.Employees.Remove(employee); }
        public void OwnersRemove(Owner owner) { this.db.Owners.Remove(owner); }
        public void CarsRemove(Car car) { this.db.Cars.Remove(car); }
        public void RequestsRemove(Request request) { this.db.Requests.Remove(request); }
        public void SuppliersRemove(Supplier supplier) { this.db.Suppliers.Remove(supplier); }
        public void SuppliesRemove(Supply supply) { this.db.Supplies.Remove(supply); }
        public void PositionsRemove(Position position) { this.db.Positions.Remove(position); }
        public void PartsRemove(Part part) { this.db.Parts.Remove(part); }
        public void StoragePartsRemove(Accounting accounting) { this.db.StorageParts.Remove(accounting); }
        #endregion

        #region Adding Methods
        public void SpecialtiesAdd(Specialty specialty) { this.db.Specialties.Add(specialty); }
        public void EmployeesAdd(Employee employee) { this.db.Employees.Add(employee); }
        public void OwnersAdd(Owner owner) { this.db.Owners.Add(owner); }
        public void CarsAdd(Car car) { this.db.Cars.Add(car); }
        public void RequestsAdd(Request request) { this.db.Requests.Add(request); }
        public void SuppliersAdd(Supplier supplier) { this.db.Suppliers.Add(supplier); }
        public void SuppliesAdd(Supply supply) { this.db.Supplies.Add(supply); }
        public void PositionsAdd(Position position) { this.db.Positions.Add(position); }
        public void PartsAdd(Part part) { this.db.Parts.Add(part); }
        public void StoragePartsAdd(Accounting accounting) { this.db.StorageParts.Add(accounting); }
        #endregion

        #region Finding Methods
        public Specialty? SpecialtiesFind(int index) { return this.db.Specialties.Find(index); }
        public Employee? EmployeesFind(int index) { return this.db.Employees.Find(index); }
        public Owner? OwnersFind(int index) { return this.db.Owners.Find(index); }
        public Car? CarsFind(int index) { return this.db.Cars.Find(index); }
        public Request? RequestsFind(int index) { return this.db.Requests.Find(index); }
        public Supplier? SuppliersFind(int index) { return this.db.Suppliers.Find(index); }
        public Supply? SuppliesFind(int index) { return this.db.Supplies.Find(index); }
        public Position? PositionsFind(int index1, int index2) { return this.db.Positions.Find([index1, index2]); }
        public Part? PartsFind(int index) { return this.db.Parts.Find(index); }
        public Accounting? StoragePartsFind(int index) { return this.db.StorageParts.Find(index); }
        #endregion

        #region Entries Methods
        public void SpecialtiesEntry(Specialty specialty) { this.db.Specialties.Entry(specialty).State = EntityState.Modified; }
        public void EmployeesEntry(Employee employee) { this.db.Employees.Entry(employee).State = EntityState.Modified; }
        public void OwnersEntry(Owner owner) { this.db.Owners.Entry(owner).State = EntityState.Modified; }
        public void CarsEntry(Car car) { this.db.Cars.Entry(car).State = EntityState.Modified; }
        public void RequestsEntry(Request request) { this.db.Requests.Entry(request).State = EntityState.Modified; }
        public void SuppliersEntry(Supplier supplier) { this.db.Suppliers.Entry(supplier).State = EntityState.Modified; }
        public void SuppliesEntry(Supply supply) { this.db.Supplies.Entry(supply).State = EntityState.Modified; }
        public void PositionsEntry(Position position) { this.db.Positions.Entry(position).State = EntityState.Modified; }
        public void PartsEntry(Part part) { this.db.Parts.Entry(part).State = EntityState.Modified; }
        public void StoragePartsEntry(Accounting accounting) { this.db.StorageParts.Entry(accounting).State = EntityState.Modified; }
        #endregion

        public void ContextSaveChanges() { this.db.SaveChanges(); }

        public void ContextDispose()
        {
            this.db.Dispose();
            this.db = null;
        }

        public List<Part> NomenclatureToList(int index)
        {
            return this.db.Suppliers
                            .Include(s => s.Parts)
                            .FirstOrDefault(s => s.SupplierId == index)?.Parts
                            .ToList();
        }

        public void EmployeesBySpecialtyLoad(int specialtyId) { this.db.Employees.Where(e => e.SpecialtyId == specialtyId).Load(); }
    }
}
