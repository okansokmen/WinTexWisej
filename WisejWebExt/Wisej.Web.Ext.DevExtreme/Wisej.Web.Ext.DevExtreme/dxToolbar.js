//# sourceURL=wisej.web.ext.DevExtremeWidget.dxToolbar.js

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

    if (options.items) {
        for (var i = 0; i < options.items.length; i++) {
            if (options.items[i].template) {
                options.items[i].template = this.initFunction(options.items[i].template);
            }
            if (options.items[i].onClick)
                options.items[i].onClick = this.initFunction(options.items[i].onClick);

            if (options.items[i].options) {
                if (options.items[i].options.onClick)
                    options.items[i].options.onClick = this.initFunction(options.items[i].options.onClick);

                if (options.items[i].options.onValueChanged)
                    options.items[i].options.onValueChanged = this.initFunction(options.items[i].options.onValueChanged);

            }
        }
    }
};

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

};
