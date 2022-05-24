import react, { useState } from 'react';
import logo from './logo.svg';
import axios from 'axios';
import './App.css';

function App() {
  const [job, setJob] = useState({});

  // Create front-end form to deliver data to API
  const submitHandler = e => {
    e.preventDefault();

    console.log(job);

    submitData(job);
  }

  // Process data on API
  const submitData = (job) => {
      axios.post('https://localhost:44385/api/job', {...job}).then(response => {
        console.log(response)
      });
  }


  return (
    <div className='container py-5'>
      <div className='row justify-content-center'>
        <div className="card" style={{width: 18 + 'rem'}}>
          <div className="card-body">
            <h5 className="card-title">Add Job</h5>
              <form onSubmit={submitHandler}>
                <input type="text" placeholder="Enter job name.." onChange={e => setJob({...job, name: e.target.value})}/>
                <select className='mt-2 form-select form-select-sm' aria-label=".form-select-sm example" onChange={e => setJob({...job, type: e.target.value})}>
                  <option>Select Exchange Type</option>
                  <option value="u">Urban</option>
                  <option value="r">Rural</option>
                  <option value="vr">Very Rural</option>
                </select>
                <button type="submit" className='btn btn-primary mt-1'>Submit</button>
              </form>
          </div>
        </div>
      </div>
    </div>
  );
}

export default App;
