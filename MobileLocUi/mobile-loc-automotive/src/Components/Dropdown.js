import React from "../../node_modules/react";

class Dropdown extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      dropdownItemsFuntion: props.dropdownItems,
      selectedId: 0
    };
    console.log("props:", props);
  }

  // handleChange = selectedId => {
  //   this.setState({ selectedId: selectedId });
  //   console.log(`Option selected:`, this.state.selectedId);
  // };

  render() {
    return (
      <div>
        <label htmlFor="CarMakeDropdown">Car Make:</label>
        <select
          id="CarMakeDropdown"
          value={this.selectedId}
          // onChange={this.handleChange}
        >
          {this.state.dropdownItemsFuntion.map(item => (
            <option key={item.id} value={item.id}>
              {item.name}
            </option>
          ))}
        </select>
      </div>
    );
  }
}

export default Dropdown;
