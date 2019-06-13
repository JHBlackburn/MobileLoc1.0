import React from "react";

class Dropdown extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      dropdownItems: [
        { makeId: 1, make: "Ford" },
        { makeId: 2, make: "Chevrolet" }
      ]
    };
  }
  render() {
    return (
      <div>
        <select>
          {this.state.dropdownItems.map(item => (
            <option value={item.makeId}>{item.make}</option>
          ))}
        </select>
      </div>
    );
  }
}

export default Dropdown;
