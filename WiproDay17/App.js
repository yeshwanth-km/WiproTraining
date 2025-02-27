//import logo from './logo.svg';
import './App.css';
import { Departments, Employees } from './Component';
import Department from './Department';
import Student from './Student';
import Welcome from './Welcome';

function App() {  
  return (
    <div>
      <Welcome></Welcome>
      <Student nam="Raj" sem="6"></Student>
      <Department dname="IT" hname="Pooja"></Department>
      <Employees name="Tharun" salary="20000" dname="IT" mgrname="Alex"></Employees>
      <Departments depname="Security" mgrname="Punit"></Departments>
    </div>
    
  );
}

export default App;
