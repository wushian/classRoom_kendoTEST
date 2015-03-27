$(document).ready(function () {
    var crudServiceBaseUrl = "http://localhost:1867/api";
    
    var calendarDetailDataSource = new kendo.data.DataSource({
        type: "json",
        transport: {
            read: {
                url: crudServiceBaseUrl + "/calendarDetail",
                dataType: "json"
            },
            create: {
                url: crudServiceBaseUrl + "/calendarDetail",
                dataType: "json",
                contentType: "application/json",
                type: "POST"
            },
            update: {
                url: crudServiceBaseUrl + "/calendarDetail",
                dataType: "json",
                contentType: "application/json",
                type: "PUT"
            },
            destroy: {
                url: function (o) {
                    return crudServiceBaseUrl + "/calendarDetail/" + o.Identification;
                },
                dataType: "json",
                type: "DELETE"
            },
            parameterMap: function(data) {
                return JSON.stringify(data);
            }
        },
        schema: {
            data: function (result) {
                return result.Data || result;
            },
            total: function (result) {
                return result.TotalCount || 1;
            },
            model: {
                id: "Identification",
                fields: {
                    Identification: {
                        type: "string",
                        validation: { required: true },
                        editable: false
                    },
                    Subject: {
                        type: "string"
                    },
                    StartDateTime: {
                        type: "date",
                        validation: { required: true }
                    },
                    EndDateTime: {
                        type: "date",
                        validation: { required: true }
                    },
                    FeeStaff: {
                        type: "number",
                        validation: { required: true }
                    },
                    FeeNonStaff: {
                        type: "number",
                        validation: { required: true }
                    },
                    Address: {
                        type: "number",
                        validation: { required: true }
                    },
                    Contact: {
                        type: "string",
                        validation: { required: true }
                    },
                    ContactTel: {
                        type: "string",
                        validation: { required: true }
                    },
                    Describe: {
                        type: "string",
                        validation: { required: true }
                    }
                }
            }
        },
        serverFiltering: true,
        serverSorting: true,
        allowUnsort: true,
        serverPaging: true,
        pageSize: 5
    });
    var grid = $("#grid").kendoGrid({
        dataSource: calendarDetailDataSource,
        pageable: true,
        filterable: true,
        sortable: true,
        navigatable: true,
        columns: [
            {
                field: "Identification",
                title: "Identification",
                filterable: false
            },
            {
                field: "Subject",
                title: "Subject"
            },
            {
                field: "StartDateTime",
                title: "Start Date Time"
            },
            {
                field: "EndDateTime",
                title: "End Date Time"
            },
            {
                field: "FeeStaff",
                title: "Fee Staff"
            },
            {
                field: "FeeNonStaff",
                title: "Fee Non Staff"
            },
            {
                field: "Contact",
                title: "Contact"
            },
            {
                field: "ContactTel",
                title: "Contact Tel"
            },
            {
                field: "Describe",
                title: "Describe"
            },
            {
                command: ["edit", "destroy"]
            }],
        editable: "inline"
    });
});