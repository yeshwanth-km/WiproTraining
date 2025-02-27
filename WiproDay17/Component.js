export const Employees = ({name, salary,dname,mgrname})=>{
    return(
    <div className='container'>
    <h5>EmployeeDetails</h5>
    <h5>Name: {name}</h5>
    <h5>Salary: {salary}</h5>
    <h5>Department Details</h5>
    <Departments depname={dname} mgrname={mgrname}></Departments>
    </div>
    )
}    
    
    
    export const Departments = ({depname,mgrname})=>{
    return (
    <div>
    <h3>DepartmentName: {depname}</h3>
    <h3>ManagerName: {mgrname}</h3>
    </div>
    )
}