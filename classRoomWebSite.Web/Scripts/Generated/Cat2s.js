$(document).ready(function () {
    var crudServiceBaseUrl = "http://localhost:1867/api";
    
    var cat2DataSource = new kendo.data.DataSource({
        type: "json",
        transport: {
            read: {
                url: crudServiceBaseUrl + "/cat2",
                dataType: "json"
            },
            create: {
                url: crudServiceBaseUrl + "/cat2",
                dataType: "json",
                contentType: "application/json",
                type: "POST"
            },
            update: {
                url: crudServiceBaseUrl + "/cat2",
                dataType: "json",
                contentType: "application/json",
                type: "PUT"
            },
            destroy: {
                url: function (o) {
                    return crudServiceBaseUrl + "/cat2/" + o.Identification;
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
                        type: "number",
                        editable: false
                    },
                    Name: {
                        type: "string"
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
        dataSource: cat2DataSource,
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
                field: "Name",
                title: "Name"
            },
            {
                command: ["edit", "destroy"]
            }],
        editable: "inline"
    });
});