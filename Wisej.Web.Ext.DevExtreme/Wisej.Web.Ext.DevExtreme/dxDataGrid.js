//# sourceURL=wisej.web.ext.DevExtremeWidget.dxDataGrid.js

///////////////////////////////////////////////////////////////////////////////
//
// (C) 2019 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////

/**
 * Process the options map before it is used to
 * create or update the widget.
 */
this.filterOptions = function (options) {

	if (options.columns) {
		for (var i = 0; i < options.columns.length; i++) {
			if (options.columns[i].cellTemplate) 
				options.columns[i].cellTemplate = this.initFunction(options.columns[i].cellTemplate);
		}
	}
};

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

	switch (args.type) {

		case "cellClick":
			return {
				columnIndex: args.columnIndex,
				rowIndex: args.rowIndex
			};
			break;

		case "selectionChanged":
			return {
				currentDeselectedRowKeys: args.currentDeselectedRowKeys,
				currentSelectedRowKeys: args.currentSelectedRowKeys,
				selectedRowKeys: args.selectedRowKeys
			};
			break;
	}
};
