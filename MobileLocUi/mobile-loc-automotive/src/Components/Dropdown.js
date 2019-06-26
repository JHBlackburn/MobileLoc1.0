import React from "../../node_modules/react";
import FetchDropdown from "./DropdownFiller";

class Dropdown extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      dropdownItems: FetchDropdown()
    };
  }
  render() {
    return (
      <div>
        <select>
          {this.state.dropdownItems.map(item => (
            <option value={item.id}>{item.name}</option>
          ))}
        </select>
      </div>
    );
  }
}

export default Dropdown;
