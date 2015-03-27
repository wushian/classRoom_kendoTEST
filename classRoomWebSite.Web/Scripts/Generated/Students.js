$(document).ready(function () {
    var crudServiceBaseUrl = "http://localhost:1867/api";
    
    var studentDataSource = new kendo.data.DataSource({
        type: "json",
        transport: {
            read: {
                url: crudServiceBaseUrl + "/student",
                dataType: "json"
            },
            create: {
                url: crudServiceBaseUrl + "/student",
                dataType: "json",
                contentType: "application/json",
                type: "POST"
            },
            update: {
                url: crudServiceBaseUrl + "/student",
                dataType: "json",
                contentType: "application/json",
                type: "PUT"
            },
            destroy: {
                url: function (o) {
                    return crudServiceBaseUrl + "/student/" + o.Identification;
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
                    BirthDay: {
                        type: "date",
                        validation: { required: true }
                    },
                    Gender: {
                        type: "string",
                        validation: { required: true }
                    },
                    CreateDate: {
                        type: "date",
                        validation: { required: true }
                    },
                    Education: {
                        type: "string",
                        validation: { required: true }
                    },
                    Address: {
                        type: "string",
                        validation: { required: true }
                    },
                    Company: {
                        type: "string",
                        validation: { required: true }
                    },
                    Telno: {
                        type: "string",
                        validation: { required: true }
                    },
                    Cellno: {
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
        dataSource: studentDataSource,
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
                field: "BirthDay",
                title: "Birth Day"
            },
            {
                field: "Gender",
                title: "Gender"
            },
            {
                field: "CreateDate",
                title: "Create Date"
            },
            {
                field: "Education",
                title: "Education"
            },
            {
                field: "Address",
                title: "Address"
            },
            {
                field: "Company",
                title: "Company"
            },
            {
                field: "Telno",
                title: "Telno"
            },
            {
                field: "Cellno",
                title: "Cellno"
            },
            {
                command: ["edit", "destroy"]
            }],
        editable: "inline"
    });
});