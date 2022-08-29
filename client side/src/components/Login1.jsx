import React from "react";
import { MDBRow, MDBCol, MDBBtn } from "mdb-react-ui-kit";

export class FormsPage extends React.Component {

  
  state = {
    name: {
      value: "",
      valid: false
    },
    password: {
        value: "",
        valid: false
      },
  };

  changeHandler = event => {
    this.setState({ [event.target.name]: { value: event.target.value, valid: !!event.target.value } });
  };

  finish=(e)=>{
    debugger
    e.preventDefault()
    alert("works")
  }
  regist=(e)=>{
   debugger
   e.preventDefault();
 alert("ihyugvgvccf")
  }


  render() {
    return (
      <div>
        <form onSubmit={(e)=>{
          debugger
          this.regist(e)
        }}>
          <MDBRow>
            <MDBCol md="4" className="mb-3">
              <label
                htmlFor="defaultFormRegisterNameEx"
                className="grey-text"
              >
              name
              </label>
              <input
                value={this.state.name.value}
                className={this.state.name.valid ? "form-control is-valid" : "form-control is-invalid"}
                name="name"
                onChange={this.changeHandler}
                type="text"
                id="defaultFormRegisterNameEx"
                placeholder="name"
                required
              />
              <div className="valid-feedback">Looks good!</div>
            </MDBCol>
            
            <MDBCol md="4" className="mb-3">
              <label
                htmlFor="defaultFormRegisterConfirmEx3"
                className="grey-text"
              >
                Password
              </label>
              <input
                value={this.state.password.value}
                className={this.state.password.valid ? "form-control is-valid" : "form-control is-invalid"}
                onChange={this.changeHandler}
                type="password"
                id="defaultFormRegisterConfirmEx3"
                name="password"
                placeholder="Your password address"
              />
              <small id="passwordHelp" className="form-text text-muted">
                We'll never share your password with anyone else.
              </small>
            </MDBCol>
          </MDBRow>
         
       
          <MDBCol md="4" className="mb-3">
            <div className="custom-control custom-checkbox pl-3">
              <input
                className="custom-control-input"
                type="checkbox"
                value=""
                id="invalidCheck"
                required
              />
              <label className="custom-control-label" htmlFor="invalidCheck">
                Agree to terms and conditions
              </label>
              <div className="invalid-feedback">
                You must agree before submitting.
              </div>
            </div>
          </MDBCol>
          <MDBBtn color="primary" type="submit" >
            Submit 
          </MDBBtn>
        </form>
      </div>
    );
  }
}

export default FormsPage;
