import React, { Component } from "react";
import "./App.css";
import Dropdown from "./components/Dropdown";

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {};
  }

  render() {
    return (
      <div className="App">
        <Dropdown />
        <Dropdown />
        <Dropdown />
      </div>
    );
  }
}

export default App;
