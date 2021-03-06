﻿#pragma warning disable 1591
// <auto-generated>
//     This code was generated from a CodeSmith Generator template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using CodeSmith.Data.Linq;
using CodeSmith.Data.Linq.Dynamic;

namespace classRoomWebSite.Data
{
    /// <summary>
    /// The query extension class for CourseIntro.
    /// </summary>
    public static partial class CourseIntroExtensions
    {
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static classRoomWebSite.Data.CourseIntro GetByKey(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, System.Guid identification)
        {
            return queryable.FirstOrDefault(c => c.Identification == identification);
        }
        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static classRoomWebSite.Data.CourseIntro GetByIdentification(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, System.Guid identification)
        {
            var entity = queryable as System.Data.Objects.ObjectSet<classRoomWebSite.Data.CourseIntro>;
            if (entity != null && !entity.Context.ContextOptions.LazyLoadingEnabled)
                return Query.GetByIdentification.Invoke((classRoomWebSite.Data.classRoomWebSiteDataContext)entity.Context, identification);

            return queryable.FirstOrDefault(c => c.Identification == identification);
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Identification"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="identification">Identification to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByIdentification(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, System.Guid identification)
        {
            return queryable.Where(c => c.Identification == identification);
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Identification"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="identification">Identification to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByIdentification(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, ComparisonOperator comparisonOperator, System.Guid identification)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return queryable.Where(c => c.Identification != identification);
                default:
                    return queryable.Where(c => c.Identification == identification);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Identification"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="identification">Identification to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByIdentification(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, System.Guid identification, params System.Guid[] additionalValues)
        {
            var identificationList = new List<System.Guid> { identification };

            if (additionalValues != null)
                identificationList.AddRange(additionalValues);

            if (identificationList.Count == 1)
                return queryable.ByIdentification(identificationList[0]);

            return queryable.ByIdentification(identificationList);
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Identification"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByIdentification(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(c => values.Contains(c.Identification));
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByName(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, System.String name)
        {
            return queryable.Where(c => c.Name == name);
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByName(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, ContainmentOperator containmentOperator, System.String name)
        {
            if (name == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("name", "Parameter 'name' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(c => c.Name.Contains(name));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(c => c.Name.StartsWith(name));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(c => c.Name.EndsWith(name));
                case ContainmentOperator.NotContains:
                    return queryable.Where(c => c.Name.Contains(name) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(c => c.Name != name);
                default:
                    return queryable.Where(c => c.Name == name);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByName(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, System.String name, params System.String[] additionalValues)
        {
            var nameList = new List<System.String> { name };

            if (additionalValues != null)
                nameList.AddRange(additionalValues);

            if (nameList.Count == 1)
                return queryable.ByName(nameList[0]);

            return queryable.ByName(nameList);
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByName(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, IEnumerable<System.String> values)
        {
            return queryable.Where(c => values.Contains(c.Name));
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Describe"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="describe">Describe to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByDescribe(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, System.String describe)
        {
            // support nulls
            return describe == null 
                ? queryable.Where(c => c.Describe == null) 
                : queryable.Where(c => c.Describe == describe);
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Describe"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="describe">Describe to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByDescribe(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, ContainmentOperator containmentOperator, System.String describe)
        {
            if (describe == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("describe", "Parameter 'describe' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(c => c.Describe.Contains(describe));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(c => c.Describe.StartsWith(describe));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(c => c.Describe.EndsWith(describe));
                case ContainmentOperator.NotContains:
                    return queryable.Where(c => c.Describe.Contains(describe) == false);
                case ContainmentOperator.NotEquals:
                    return describe == null 
                        ? queryable.Where(c => c.Describe != null) 
                        : queryable.Where(c => c.Describe != describe);
                default:
                    return describe == null 
                        ? queryable.Where(c => c.Describe == null) 
                        : queryable.Where(c => c.Describe == describe);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Describe"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="describe">Describe to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByDescribe(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, System.String describe, params System.String[] additionalValues)
        {
            var describeList = new List<System.String> { describe };

            if (additionalValues != null)
                describeList.AddRange(additionalValues);
            else
                describeList.Add(null);

            if (describeList.Count == 1)
                return queryable.ByDescribe(describeList[0]);

            return queryable.ByDescribe(describeList);
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Describe"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByDescribe(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, IEnumerable<System.String> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<classRoomWebSite.Data.CourseIntro, bool>("Describe", values);
            return queryable.Where(expression);
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Pic2"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="pic2">Pic2 to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByPic2(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, System.String pic2)
        {
            // support nulls
            return pic2 == null 
                ? queryable.Where(c => c.Pic2 == null) 
                : queryable.Where(c => c.Pic2 == pic2);
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Pic2"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="pic2">Pic2 to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByPic2(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, ContainmentOperator containmentOperator, System.String pic2)
        {
            if (pic2 == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("pic2", "Parameter 'pic2' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(c => c.Pic2.Contains(pic2));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(c => c.Pic2.StartsWith(pic2));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(c => c.Pic2.EndsWith(pic2));
                case ContainmentOperator.NotContains:
                    return queryable.Where(c => c.Pic2.Contains(pic2) == false);
                case ContainmentOperator.NotEquals:
                    return pic2 == null 
                        ? queryable.Where(c => c.Pic2 != null) 
                        : queryable.Where(c => c.Pic2 != pic2);
                default:
                    return pic2 == null 
                        ? queryable.Where(c => c.Pic2 == null) 
                        : queryable.Where(c => c.Pic2 == pic2);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Pic2"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="pic2">Pic2 to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByPic2(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, System.String pic2, params System.String[] additionalValues)
        {
            var pic2List = new List<System.String> { pic2 };

            if (additionalValues != null)
                pic2List.AddRange(additionalValues);
            else
                pic2List.Add(null);

            if (pic2List.Count == 1)
                return queryable.ByPic2(pic2List[0]);

            return queryable.ByPic2(pic2List);
        }

        /// <summary>
        /// Gets a query for <see cref="classRoomWebSite.Data.CourseIntro.Pic2"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
        public static IQueryable<classRoomWebSite.Data.CourseIntro> ByPic2(this IQueryable<classRoomWebSite.Data.CourseIntro> queryable, IEnumerable<System.String> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<classRoomWebSite.Data.CourseIntro, bool>("Pic2", values);
            return queryable.Where(expression);
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {
            [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
            internal static readonly Func<classRoomWebSite.Data.classRoomWebSiteDataContext, System.Guid, classRoomWebSite.Data.CourseIntro> GetByKey =
                System.Data.Objects.CompiledQuery.Compile(
                    (classRoomWebSite.Data.classRoomWebSiteDataContext db, System.Guid identification) =>
                        db.CourseIntro.FirstOrDefault(c => c.Identification == identification));

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith Generator", "6.0.0.0")]
            internal static readonly Func<classRoomWebSite.Data.classRoomWebSiteDataContext, System.Guid, classRoomWebSite.Data.CourseIntro> GetByIdentification =
                System.Data.Objects.CompiledQuery.Compile(
                    (classRoomWebSite.Data.classRoomWebSiteDataContext db, System.Guid identification) =>
                        db.CourseIntro.FirstOrDefault(c => c.Identification == identification));

        }
        #endregion
    }
}
#pragma warning restore 1591
