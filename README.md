
# SuppliersAndProducts

Asp.Net Core MVC ile hazırlanmış Tedarikçi ve ürünler uygulaması.
Code First yaklaşımı ile hazırlandı ve repository design pattern kullanıldı.
Database Migrationlarından sonra Postman ile api kullanılabilir.

    API 
     
| Route | HTTP | Method | Description |
| --- | --- | --- | --- |
| /api/auth/register | POST | {'username':emresalman1, 'password':12345} | Send UserName and Password for Register |
| /api/auth/login | POST | {'username':emresalman1, 'password':12345} | Send userName and Password for Login |
| /api/suppliers/add  | POST | {'supplierName':supplier One,} | Send SupplierName for add supplier |
| /api/suppliers/GetSuppliers | Get | - | for get all Suppliers |
| /api/suppliers/GetSupplierByID/{id} | Get | /2 | for get supplier by SupplierID |
| /api/suppliers/GetProductBySupplier/{id} | Get | /2 | for get products by SupplierID |
| /api/products/GetProducts | Get | - | Get all Product |
| /api/suppliers/Delete/{id} | Delete | /2 | Delete supplier |
| /api/products/Delete/{id} | Delete | /2 | Delete product |
| /api/suppliers/Update | Put |{'supplierName':supplier Two,'supplierID':1,}  | Send SupplierName and SupplierID for update supplier |
