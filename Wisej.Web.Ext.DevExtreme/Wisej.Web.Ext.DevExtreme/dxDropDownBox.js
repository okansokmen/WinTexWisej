//# sourceURL=wisej.web.ext.DevExtremeWidget.dxDropDownBox.js

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

    if (options.contentTemplate)
        options.contentTemplate = this.initFunction(options.contentTemplate);

    if (options.displayExpr)
        options.displayExpr = this.initFunction(options.displayExpr);
};

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

    switch (args.type) {

        case "valueChanged":
            return {
                previousValue: args.previousValue,
                value: args.value
            }
    }
};
