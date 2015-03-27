$(document).ready(function () {
    var crudServiceBaseUrl = "http://localhost:1867/api";
    
    var systemUserDataSource = new kendo.data.DataSource({
        type: "json",
        transport: {
            read: {
                url: crudServiceBaseUrl + "/systemUser",
                dataType: "json"
            },
            create: {
                url: crudServiceBaseUrl + "/systemUser",
                dataType: "json",
                contentType: "application/json",
                type: "POST"
            },
            update: {
                url: crudServiceBaseUrl + "/systemUser",
                dataType: "json",
                contentType: "application/json",
                type: "PUT"
            },
            destroy: {
                url: function (o) {
                    return crudServiceBaseUrl + "/systemUser/" + o.Identification;
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
                    Name: {
                        type: "string"
                    },
                    Account: {
                        type: "string"
                    },
                    Password: {
                        type: "string"
                    },
                    Salt: {
                        type: "string"
                    },
                    Email: {
                        type: "string"
                    },
                    CreateDate: {
                        type: "date"
                    },
                    UpdateDate: {
                        type: "date"
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
        dataSource: systemUserDataSource,
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
                field: "Account",
                title: "Account"
            },
            {
                field: "Password",
                title: "Password"
            },
            {
                field: "Salt",
                title: "Salt"
            },
            {
                field: "Email",
                title: "Email"
            },
            {
                field: "CreateDate",
                title: "Create Date"
            },
            {
                field: "UpdateDate",
                title: "Update Date"
            },
            {
                command: ["edit", "destroy"]
            }],
        editable: "inline"
    });
});