using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementTool
{
    public class FactoryHelper
    {
        private readonly string _projectPath;
        private readonly Type _entity;
        public FactoryHelper(string projectPath, Type entity)
        {
            _projectPath = projectPath;
            _entity = entity;
        }

        public T As<T>() where T : class
        {
            var instance = Activator.CreateInstance(typeof(T), _projectPath, _entity);
            return instance as T;
        }
    }
}
