// <auto-generated />

using System;
using System.Reflection;
using System.Resources;
using System.Threading;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Microsoft.EntityFrameworkCore.Sqlite.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static class SqliteStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Sqlite.Properties.SqliteStrings", typeof(SqliteStrings).Assembly);

        /// <summary>
        ///     SQLite does not support this migration operation ('{operation}'). For more information, see http://go.microsoft.com/fwlink/?LinkId=723262.
        /// </summary>
        public static string InvalidMigrationOperation([CanBeNull] object operation)
            => string.Format(
                GetString("InvalidMigrationOperation", nameof(operation)),
                operation);

        /// <summary>
        ///     Generating idempotent scripts for migration is not currently supported by SQLite. For more information, see http://go.microsoft.com/fwlink/?LinkId=723262.
        /// </summary>
        public static string MigrationScriptGenerationNotSupported
            => GetString("MigrationScriptGenerationNotSupported");

        /// <summary>
        ///     SQLite does not support sequences. For more information, see http://go.microsoft.com/fwlink/?LinkId=723262.
        /// </summary>
        public static string SequencesNotSupported
            => GetString("SequencesNotSupported");

        /// <summary>
        ///     SQLite cannot order by expressions of type '{type}'. Convert the values to a supported type or use LINQ to Objects to order the results.
        /// </summary>
        public static string OrderByNotSupported([CanBeNull] object type)
            => string.Format(
                GetString("OrderByNotSupported", nameof(type)),
                type);

        /// <summary>
        ///     '{entityType1}.{property1}' and '{entityType2}.{property2}' are both mapped to column '{columnName}' in '{table}' but are configured with different SRIDs.
        /// </summary>
        public static string DuplicateColumnNameSridMismatch([CanBeNull] object entityType1, [CanBeNull] object property1, [CanBeNull] object entityType2, [CanBeNull] object property2, [CanBeNull] object columnName, [CanBeNull] object table)
            => string.Format(
                GetString("DuplicateColumnNameSridMismatch", nameof(entityType1), nameof(property1), nameof(entityType2), nameof(property2), nameof(columnName), nameof(table)),
                entityType1, property1, entityType2, property2, columnName, table);

        /// <summary>
        ///     SQLite cannot apply aggregate operator '{aggregateOperator}' on expression of type '{type}'. Convert the values to a supported type or use LINQ to Objects to aggregate the results.
        /// </summary>
        public static string AggregateOperationNotSupported([CanBeNull] object aggregateOperator, [CanBeNull] object type)
            => string.Format(
                GetString("AggregateOperationNotSupported", nameof(aggregateOperator), nameof(type)),
                aggregateOperator, type);

        /// <summary>
        ///     Translating this query requires APPLY operation which is not supported on SQLite.
        /// </summary>
        public static string ApplyNotSupported
            => GetString("ApplyNotSupported");

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}

namespace Microsoft.EntityFrameworkCore.Sqlite.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static class SqliteResources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Sqlite.Properties.SqliteStrings", typeof(SqliteResources).Assembly);

        /// <summary>
        ///     The entity type '{entityType}' is configured to use schema '{schema}'. SQLite does not support schemas. This configuration will be ignored by the SQLite provider.
        /// </summary>
        public static EventDefinition<string, string> LogSchemaConfigured([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogSchemaConfigured;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogSchemaConfigured,
                    () => new EventDefinition<string, string>(
                        logger.Options,
                        SqliteEventId.SchemaConfiguredWarning,
                        LogLevel.Warning,
                        "SqliteEventId.SchemaConfiguredWarning",
                        level => LoggerMessage.Define<string, string>(
                            level,
                            SqliteEventId.SchemaConfiguredWarning,
                            _resourceManager.GetString("LogSchemaConfigured"))));
            }

            return (EventDefinition<string, string>)definition;
        }

        /// <summary>
        ///     The model was configured with the database sequence '{sequence}'. SQLite does not support sequences.
        /// </summary>
        public static EventDefinition<string> LogSequenceConfigured([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogSequenceConfigured;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogSequenceConfigured,
                    () => new EventDefinition<string>(
                        logger.Options,
                        SqliteEventId.SequenceConfiguredWarning,
                        LogLevel.Warning,
                        "SqliteEventId.SequenceConfiguredWarning",
                        level => LoggerMessage.Define<string>(
                            level,
                            SqliteEventId.SequenceConfiguredWarning,
                            _resourceManager.GetString("LogSequenceConfigured"))));
            }

            return (EventDefinition<string>)definition;
        }

        /// <summary>
        ///     SQLite doesn't support schemas. The specified schema selection arguments will be ignored.
        /// </summary>
        public static EventDefinition LogUsingSchemaSelectionsWarning([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogUsingSchemaSelectionsWarning;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogUsingSchemaSelectionsWarning,
                    () => new EventDefinition(
                        logger.Options,
                        SqliteEventId.SchemasNotSupportedWarning,
                        LogLevel.Warning,
                        "SqliteEventId.SchemasNotSupportedWarning",
                        level => LoggerMessage.Define(
                            level,
                            SqliteEventId.SchemasNotSupportedWarning,
                            _resourceManager.GetString("LogUsingSchemaSelectionsWarning"))));
            }

            return (EventDefinition)definition;
        }

        /// <summary>
        ///     Found column on table: {tableName}, column name: {columnName}, data type: {dataType}, not nullable: {isNotNullable}, default value: {defaultValue}.
        /// </summary>
        public static EventDefinition<string, string, string, bool, string> LogFoundColumn([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundColumn;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundColumn,
                    () => new EventDefinition<string, string, string, bool, string>(
                        logger.Options,
                        SqliteEventId.ColumnFound,
                        LogLevel.Debug,
                        "SqliteEventId.ColumnFound",
                        level => LoggerMessage.Define<string, string, string, bool, string>(
                            level,
                            SqliteEventId.ColumnFound,
                            _resourceManager.GetString("LogFoundColumn"))));
            }

            return (EventDefinition<string, string, string, bool, string>)definition;
        }

        /// <summary>
        ///     Found foreign key on table: {tableName}, id: {id}, principal table: {principalTableName}, delete action: {deleteAction}.
        /// </summary>
        public static EventDefinition<string, long, string, string> LogFoundForeignKey([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundForeignKey;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundForeignKey,
                    () => new EventDefinition<string, long, string, string>(
                        logger.Options,
                        SqliteEventId.ForeignKeyFound,
                        LogLevel.Debug,
                        "SqliteEventId.ForeignKeyFound",
                        level => LoggerMessage.Define<string, long, string, string>(
                            level,
                            SqliteEventId.ForeignKeyFound,
                            _resourceManager.GetString("LogFoundForeignKey"))));
            }

            return (EventDefinition<string, long, string, string>)definition;
        }

        /// <summary>
        ///     Could not scaffold the foreign key '{foreignKeyName}'. The referenced table could not be found. This most likely occurred because the referenced table was excluded from scaffolding.
        /// </summary>
        public static EventDefinition<string> LogForeignKeyScaffoldErrorPrincipalTableNotFound([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogForeignKeyScaffoldErrorPrincipalTableNotFound;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogForeignKeyScaffoldErrorPrincipalTableNotFound,
                    () => new EventDefinition<string>(
                        logger.Options,
                        SqliteEventId.ForeignKeyReferencesMissingTableWarning,
                        LogLevel.Warning,
                        "SqliteEventId.ForeignKeyReferencesMissingTableWarning",
                        level => LoggerMessage.Define<string>(
                            level,
                            SqliteEventId.ForeignKeyReferencesMissingTableWarning,
                            _resourceManager.GetString("LogForeignKeyScaffoldErrorPrincipalTableNotFound"))));
            }

            return (EventDefinition<string>)definition;
        }

        /// <summary>
        ///     Found table with name: {name}.
        /// </summary>
        public static EventDefinition<string> LogFoundTable([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundTable;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundTable,
                    () => new EventDefinition<string>(
                        logger.Options,
                        SqliteEventId.TableFound,
                        LogLevel.Debug,
                        "SqliteEventId.TableFound",
                        level => LoggerMessage.Define<string>(
                            level,
                            SqliteEventId.TableFound,
                            _resourceManager.GetString("LogFoundTable"))));
            }

            return (EventDefinition<string>)definition;
        }

        /// <summary>
        ///     Unable to find a table in the database matching the selected table {table}.
        /// </summary>
        public static EventDefinition<string> LogMissingTable([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogMissingTable;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogMissingTable,
                    () => new EventDefinition<string>(
                        logger.Options,
                        SqliteEventId.MissingTableWarning,
                        LogLevel.Warning,
                        "SqliteEventId.MissingTableWarning",
                        level => LoggerMessage.Define<string>(
                            level,
                            SqliteEventId.MissingTableWarning,
                            _resourceManager.GetString("LogMissingTable"))));
            }

            return (EventDefinition<string>)definition;
        }

        /// <summary>
        ///     For foreign key with identity {id} on table {tableName}, unable to find the column called {principalColumnName} on the foreign key's principal table, {principaltableName}. Skipping foreign key.
        /// </summary>
        public static EventDefinition<string, string, string, string> LogPrincipalColumnNotFound([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogPrincipalColumnNotFound;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogPrincipalColumnNotFound,
                    () => new EventDefinition<string, string, string, string>(
                        logger.Options,
                        SqliteEventId.ForeignKeyPrincipalColumnMissingWarning,
                        LogLevel.Warning,
                        "SqliteEventId.ForeignKeyPrincipalColumnMissingWarning",
                        level => LoggerMessage.Define<string, string, string, string>(
                            level,
                            SqliteEventId.ForeignKeyPrincipalColumnMissingWarning,
                            _resourceManager.GetString("LogPrincipalColumnNotFound"))));
            }

            return (EventDefinition<string, string, string, string>)definition;
        }

        /// <summary>
        ///     Found index with name: {indexName}, table: {tableName}, is unique: {isUnique}.
        /// </summary>
        public static EventDefinition<string, string, bool?> LogFoundIndex([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundIndex;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundIndex,
                    () => new EventDefinition<string, string, bool?>(
                        logger.Options,
                        SqliteEventId.IndexFound,
                        LogLevel.Debug,
                        "SqliteEventId.IndexFound",
                        level => LoggerMessage.Define<string, string, bool?>(
                            level,
                            SqliteEventId.IndexFound,
                            _resourceManager.GetString("LogFoundIndex"))));
            }

            return (EventDefinition<string, string, bool?>)definition;
        }

        /// <summary>
        ///     Found primary key with name: {primaryKeyName}, table: {tableName}.
        /// </summary>
        public static EventDefinition<string, string> LogFoundPrimaryKey([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundPrimaryKey;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundPrimaryKey,
                    () => new EventDefinition<string, string>(
                        logger.Options,
                        SqliteEventId.PrimaryKeyFound,
                        LogLevel.Debug,
                        "SqliteEventId.PrimaryKeyFound",
                        level => LoggerMessage.Define<string, string>(
                            level,
                            SqliteEventId.PrimaryKeyFound,
                            _resourceManager.GetString("LogFoundPrimaryKey"))));
            }

            return (EventDefinition<string, string>)definition;
        }

        /// <summary>
        ///     Found unique constraint with name: {uniqueConstraintName}, table: {tableName}.
        /// </summary>
        public static EventDefinition<string, string> LogFoundUniqueConstraint([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundUniqueConstraint;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundUniqueConstraint,
                    () => new EventDefinition<string, string>(
                        logger.Options,
                        SqliteEventId.UniqueConstraintFound,
                        LogLevel.Debug,
                        "SqliteEventId.UniqueConstraintFound",
                        level => LoggerMessage.Define<string, string>(
                            level,
                            SqliteEventId.UniqueConstraintFound,
                            _resourceManager.GetString("LogFoundUniqueConstraint"))));
            }

            return (EventDefinition<string, string>)definition;
        }

        /// <summary>
        ///     A connection of an unexpected type ({type}) is being used. The SQL functions prefixed with 'ef_' could not be created automatically. Manually define them if you encounter errors while querying.
        /// </summary>
        public static EventDefinition<string> LogUnexpectedConnectionType([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogUnexpectedConnectionType;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogUnexpectedConnectionType,
                    () => new EventDefinition<string>(
                        logger.Options,
                        SqliteEventId.UnexpectedConnectionTypeWarning,
                        LogLevel.Warning,
                        "SqliteEventId.UnexpectedConnectionTypeWarning",
                        level => LoggerMessage.Define<string>(
                            level,
                            SqliteEventId.UnexpectedConnectionTypeWarning,
                            _resourceManager.GetString("LogUnexpectedConnectionType"))));
            }

            return (EventDefinition<string>)definition;
        }
    }
}
