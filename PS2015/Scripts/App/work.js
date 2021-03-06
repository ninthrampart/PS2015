﻿app.WorkItem = Backbone.Model.extend({

});

app.WorkList = Backbone.Collection.extend({
    model: app.WorkItem,
    url: "/api/Work/GetForPassport/123"
});

InternalWorkView = Backbone.Marionette.ItemView.extend({
    template: "#ps_internalwork",
    tagName: 'tr',
    className: 'ps_internalwork'

});

InternalWorkLisView = Backbone.Marionette.CompositeView.extend({
    template: "#ps_internalworks",
    className: 'ps_internalworks',
    childView: InternalWorkView,
    childViewContainer: "tbody"
});

SubctontractWorkView = Backbone.Marionette.ItemView.extend({
    template: "#ps_subcontractwork",
    tagName: 'tr',
    className: 'ps_subcontractwork'

});

SubctontractWorkLisView = Backbone.Marionette.CompositeView.extend({
    template: "#ps_subcontractworks",
    className: 'ps_subcontractworks',
    childView: SubctontractWorkView,
    childViewContainer: "tbody"
});